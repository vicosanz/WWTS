$project = "Siembra"
$dll = ".\WWTS.$($project)\WWTS.$($project).Modulo\bin\Release\$($project).exe"
$fulldll = Resolve-Path $dll
$version = [System.Diagnostics.FileVersionInfo]::GetVersionInfo($fulldll).FileVersion
$nugetpack = ".\nuget.exe pack"
Invoke-Expression "$($nugetpack) $($project).nuspec -Version $($version) -properties project=$($project)"

$squirrelreleasify = "Squirrel -releasify"
Invoke-Expression "$($squirrelreleasify) .\$($project).$($version).nupkg"
