$project = "Roles"
$dll = ".\WWTS.$($project)\WWTS.$($project).Modulo\bin\Release\$($project).exe"
$fulldll = Resolve-Path $dll
$version = [System.Diagnostics.FileVersionInfo]::GetVersionInfo($fulldll).FileVersion
$nugetpack = ".\nuget.exe pack $($project).nuspec -Version $($version) -properties project=$($project)"
Write-Output "$($nugetpack)"
Invoke-Expression "$($nugetpack)"

$squirrelreleasify = "Squirrel -releasify .\$($project).$($version).nupkg"
Write-Output "$($squirrelreleasifyh)"
Invoke-Expression "$($squirrelreleasify)"

$push = "C:\Projects\GitHubPushRelease\GitHubPushRelease\bin\Release\net5.0\GitHubPushRelease.exe -u=vicosanz -r=$($project)installer -f='.\Releases'"
Write-Output "$($push)"
Invoke-Expression "$($push)"
