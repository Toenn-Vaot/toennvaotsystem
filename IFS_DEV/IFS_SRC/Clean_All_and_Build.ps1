# Clean All And Build Projects
# ---------------------------------------------------------------------
# Created at : 14/08/2023
# Description: This tool clean and build project to generate the
#              system (websites, librairies, ...)
# ---------------------------------------------------------------------

if((Get-InstalledModule -Name 'CredentialManager' | Measure-Object).Count -eq 0){
    Write-Color "--", " Install Powershell Modules" -C Gray, Yellow
    Install-PackageProvider -Name NuGet -MinimumVersion 2.8.5.201 -Force
    Install-Module CredentialManager -force
}

# Include Powershell COMMON Script includes common functions
if ($host.name -eq 'ConsoleHost') # or -notmatch 'ISE'
{
	. (Join-Path (Split-Path $MyInvocation.MyCommand.Definition | Split-Path) "OTHER_DEV\_BUILD\PowershellCommonScripts\Common.ps1")
	. (Join-Path (Split-Path $MyInvocation.MyCommand.Definition | Split-Path) "OTHER_DEV\_BUILD\PowershellCommonScripts\CommonBuild.ps1")
}
else
{
	. (Join-Path (Split-Path $env:IFSBOHOME) "IFS_DEV\OTHER_DEV\_BUILD\PowershellCommonScripts\Common.ps1")
	. (Join-Path (Split-Path $env:IFSBOHOME) "IFS_DEV\OTHER_DEV\_BUILD\PowershellCommonScripts\CommonBuild.ps1")
}

# Define Build project arrays
$global:buildProjectsArr = "ToennVaot.Components.Core"

$buildParallel = @(
    (1, @("ToennVaot.Components.Core"))
)

#$publishProjects = @("Acm")

# Prerequesites
# --------------------------------------------------------------------
Set-ExecutionPolicy Unrestricted -Force -Scope Process

Push-Location

Clear-Host

if([intptr]::Size -lt 8) {
    Write-Error "You must launch this script with Powershell 64bits due to linked modules" -ErrorAction Stop -RecommendedAction "Launch the script with 'C:\Windows\System32\WindowsPowerShell\v1.0\powershell.exe'"
}
Clear-Host

    # Header of the script
    # --------------------------------------------------------------------    
    " ******************************************************************** "
    " * Clean and build projects                                         * "
    " * ------------------------------------------------------------------ "
    " * TOENN VAOT                                                       * "
    " * Created : 14/08/2023                                             * "
    " ******************************************************************** "	
        
    # Determine the environment information
    # --------------------------------------------------------------------
    $os = (Get-WmiObject Win32_OperatingSystem)
    $processor = (Get-WmiObject Win32_Processor)
    $dotnetVersion = (dotnet --version)
    
    " *                                                                  * "	
	" * Dotnet : {0}                                                 * " -f $dotnetVersion
    " ******************************************************************** "
	
    # Determine the building folders and variables
    # --------------------------------------------------------------------
    $viewDevFolder = Join-Path (Split-Path $env:IFSBOHOME) "IFS_DEV"
    $viewSrcFolder = Join-Path $viewDevFolder "IFS_SRC"
    $viewFolder = Split-Path $viewSrcFolder | Split-Path | Split-Path
    $viewsFolder = Split-Path $viewSrcFolder | Split-Path | Split-Path | Split-Path
    $viewOtherDevFolder = Join-Path (Split-Path $viewSrcFolder) "OTHER_DEV"
    $viewWebFolder = Join-Path (Split-Path $viewSrcFolder) "IFS_WEB"
    $viewGenFolder = Join-Path (Split-Path $viewSrcFolder | Split-Path) "IFS_GEN"
    $viewLogsFolder = Join-Path $viewGenFolder "Log"
            
    $viewGenDataFolder = Join-Path $viewGenFolder "Data"
    
    # Determine the executing parameters
    # --------------------------------------------------------------------
    $target = Get-TargetChoice "What is the build target you want to use :"
	$generateBoms = $false
    Write-Host
        
    # Determine the Repository environment
    # --------------------------------------------------------------------
    $viewRoot = Split-Path $viewSrcFolder | Split-Path | Split-Path
    $viewName = Split-Path $viewRoot -leaf
        
    # Determine the log variables
    # --------------------------------------------------------------------
    Set-Variable logsRoot -Value "C:\IFS_BUILD_LOGS"
    Set-Variable logFolderName -Value (("{0}_{1}_{2}" -f $viewName, (Get-Date -format('s')), $target) -replace ":", "-")
    Set-Variable logBuildFolderName -Value "Build"

    Set-Variable logFolder (Join-Path $logsRoot $logFolderName)
    Set-Variable logBuildFolder -Value (Join-Path $logFolder $logBuildFolderName)

    Set-Variable logExecutionTime -Value ("{0}\{1}" -f $logFolder, "ExecutionTimeLogging.txt")
            
    Set-Variable logJobsFailures -Value ("{0}\{1}" -f $logFolder, "BuildParallelFailures.txt")
	
    # Create the log folders
    # ----------------------------------------------------------------
    New-Item $logFolder -type directory -ErrorAction Stop | Out-Null
    New-Item $logBuildFolder -type directory -ErrorAction Stop | Out-Null
    	
    # Create the data folder
    # ----------------------------------------------------------------
    if(-not (Test-Path (Join-Path $viewGenFolder "Data")))
    {
		New-Item (Join-Path $viewGenFolder "Data") -type directory -ErrorAction Stop | Out-Null
    }

    
Write-Host

# Executing the process according to parameters
# --------------------------------------------------------------------
Start-Transcript -Path (Join-Path $logFolder "Main_Build.log") | Out-Null

    "OS                     : {0}{1}" -f $os.Caption, $os.CSDVersion
    "Nb Processor           : {0}" -f $processor.NumberOfCores
    "Powershell(x64)        : {0}" -f [intptr]::Size
    "Architecture           : {0}" -f $os.OSArchitecture
    
    Write-Host
    
    "IFS_SRC Folder         : {0}" -f $viewSrcFolder
    "IFS_WEB Folder         : {0}" -f $viewWebFolder 
    "IFS_GEN Folder         : {0}" -f $viewGenFolder
    
    Write-Host      

    "Repository Name        : {0}" -f $viewName
    "Target of the Build    : {0}" -f $target
    
    Write-Host
    
    "Log Folder             : {0}" -f $logFolder
    "Log Build Folder       : {0}" -f $logBuildFolder
    
    Write-Host

Add-Content -Path $logExecutionTime -Value ("[START] {0}" -f (Get-Date -format('s')))
Add-Content -Path $logExecutionTime -Value ("[REPOSITORYNAME] {0}" -f $viewName)
Add-Content -Path $logExecutionTime -Value ""

$timeProcess = [System.Diagnostics.Stopwatch]::StartNew()

Write-Color "Trust development certificate" -C Green
dotnet dev-certs https --trust | Out-Null

Write-Host
Write-Color "Clear NuGet cache" -C Cyan
dotnet nuget locals all --clear | Out-Null

if(Test-Path((Join-Path $env:SystemDrive "inetpub\wwwroot\BaGet")))
{    
    Write-Color "    - Stop ", "BaGet", " application pool" -C Gray, Yellow, Gray
    Stop-WebAppPool BaGet -ErrorAction SilentlyContinue
    do {        
        $status = (Get-WebAppPoolState -name "BaGet").Value
        Start-Sleep -Milliseconds 100
    } while (-not($status -eq "Stopped"))

    Write-Color "    - Remove ", "Local Nuget", " database" -C Gray, Yellow, Gray
    Remove-Item (Join-Path $env:SystemDrive "inetpub\wwwroot\BaGet\BaGet.db") -Force -ErrorAction SilentlyContinue | Out-Null
    Remove-Item (Join-Path $env:SystemDrive "inetpub\wwwroot\BaGet\packages") -Recurse -Force -ErrorAction SilentlyContinue | Out-Null
    Remove-Item (Join-Path $env:SystemDrive "inetpub\wwwroot\BaGet\symbols") -Recurse -Force -ErrorAction SilentlyContinue | Out-Null
        
    Write-Color "    - Remove ", "Local GEN stuff", " database" -C Gray, Yellow, Gray
    Remove-Item (Join-Path $env:IFSBOHOME "nupkgs") -Recurse -Force -ErrorAction SilentlyContinue | Out-Null
    Remove-Item (Join-Path $env:IFSBOHOME "packages") -Recurse -Force -ErrorAction SilentlyContinue | Out-Null

    Write-Color "    - Restart ", "BaGet", " application pool" -C Gray, Yellow, Gray
    Start-WebAppPool BaGet -ErrorAction Stop
}

Write-Host
Write-Host "Build components"
    
Push-Location

$timeBuildProjects = [System.Diagnostics.Stopwatch]::StartNew()

$i=1
foreach($phase in $buildParallel)
{
    Write-Host ("-- Phase {0}" -f $i) -ForegroundColor red
    
    $pf = $viewSrcFolder
    $bpSuccess = LaunchPhase -id $i -p $phase -pf $pf -t $target -lbf $logBuildFolder -let $logExecutionTime -odf $viewOtherDevFolder -pp $publishProjects -bom $generateBoms #-Verbose

    if(-not($bpSuccess))
    {
        $buildSuccess = $false
        break
    }
    else
    {
        $buildSuccess = $bpSuccess
    }
    $i++
}

#foreach($publishProject in $publishProjects) {
#    if(Test-Path((Join-Path $env:IFSBOHOME "..\IFS_DEV\OTHER_DEV\_TRANSFORMS\$publishProject\appsettings.json"))) {
#        Copy-Item -Path (Join-Path $env:IFSBOHOME "..\IFS_DEV\OTHER_DEV\_TRANSFORMS\$publishProject\appsettings.json") -Destination (Join-Path $env:IFSBOHOME "ToennVaot.$publishProject\net5.0\publish\appsettings.json") -Force
#    }
#}

$timeBuildProjects.Stop()

Remove-Job Phase*

Pop-Location
    
$timeProcess.Stop()

Add-Content -Path $logExecutionTime -Value ""
Add-Content -Path $logExecutionTime -Value ("... elapsed {0:N2} minutes" -f $timeProcess.Elapsed.TotalMinutes)
Add-Content -Path $logExecutionTime -Value ""

Write-Host
Write-Color "... elapsed ", ("{0:N2}" -f $timeProcess.Elapsed.TotalMinutes), " minutes" -C Gray, Yellow, Gray
Write-Host

Stop-Transcript | Out-Null

# Open the log folder
# ---------------------------------------------------------------
if(($buildSuccess -eq $False) -or (Get-BoolChoice "Do you want to open the log folder ?" -defaultValue "n"))
{
    ii $logFolder
}
Write-Host

Pop-Location
