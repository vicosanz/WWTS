$project = "FichasMedicas"

$msBuild = "msbuild"
try
{
    & $msBuild /version
    Write-Host "Likely on Linux/macOS."
}
catch
{
    Write-Host "MSBuild doesn't exist. Use VSSetup instead."

    Install-Module VSSetup -Scope CurrentUser -Force
    $instance = Get-VSSetupInstance -All | Select-VSSetupInstance -Latest
    $installDir = $instance.installationPath
    $msBuild = $installDir + '\MSBuild\Current\Bin\MSBuild.exe'
    if (![System.IO.File]::Exists($msBuild))
    {
        Write-Host "MSBuild 16 doesn't exist."
        $msBuild = $installDir + '\MSBuild\15.0\Bin\MSBuild.exe'
        if (![System.IO.File]::Exists($msBuild))
        {
            Write-Host "MSBuild 15 doesn't exist. Exit."
            exit 1
        }
        else
        {
            Write-Host "Likely on Windows with VS2017."
        }
    }
    else
    {
        Write-Host "Likely on Windows with VS2019."
    }
}

Write-Host "MSBuild found. Compile the projects."

& $msBuild $project.sln /p:Configuration=Release /t:restore
& $msBuild $project.sln /p:Configuration=Release /t:clean
& $msBuild $project.sln /p:Configuration=Release

Write-Host "Compilation finished."

$dll = ".\WWTS.$($project)\WWTS.$($project).Modulo\bin\Release\$($project).exe"
$fulldll = Resolve-Path $dll
$version = [System.Diagnostics.FileVersionInfo]::GetVersionInfo($fulldll).FileVersion
$nugetpack = ".\nuget.exe pack  $($project).nuspec -Version $($version) -properties project=$($project)"
Write-Host "$($nugetpack)"
Invoke-Expression "$($nugetpack)"

$squirrelreleasify = "Squirrel -releasify .\$($project).$($version).nupkg"
Write-Host "$($squirrelreleasifyh)"
Invoke-Expression "$($squirrelreleasify)"

$push = "C:\Projects\GitHubPushRelease\GitHubPushRelease\bin\Release\net5.0\GitHubPushRelease.exe -u=vicosanz -r=$($project)installer -f='.\Releases'"
Write-Host "$($push)"
Invoke-Expression "$($push)"
