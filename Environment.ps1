if(-not(Get-Module -name psake))
{
	$psake_path = (Get-ChildItem psake.psm1 -r | Sort-Object Name | Select-Object -First 1).FullName
	Import-Module $psake_path
	Echo "Imported psake from $psake_path"
}