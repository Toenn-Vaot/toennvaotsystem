import-module WebAdministration #Add the module to administrate IIS

Function BuildProject
{
    [cmdletbinding()]
    param (
        [Parameter(Mandatory=$True, HelpMessage='What is the solution folder ?')]
        [Alias("sf")]
        [string]$solutionFolder,
        [Parameter(Mandatory=$True, HelpMessage='What is the solution name you want to build ?')]
        [Alias("pn")]
        [string]$projectName,
        [Parameter(Mandatory=$True, HelpMessage='What is the target of the build ?')]
        [Alias("t")]
        [string]$target,
        [Parameter(Mandatory=$True, HelpMessage='What is the folder of build logs ?')]
        [Alias("lbf")]
        [string]$_logBuildFolder,
        [Parameter(Mandatory=$True, HelpMessage='What is the full path of the execution time log ?')]
        [Alias("let")]
        [string]$_logExecutionTime
    )
    
    process
    {
        $logBuildFile = "{0}\{1}_build.log" -f $_logBuildFolder, $projectName
        $logBuildWarnFile = "{0}\{1}_build_warn.log" -f $_logBuildFolder, $projectName
        
        $timeBuild = [System.Diagnostics.Stopwatch]::StartNew()
        Push-Location
        cd (Join-Path $solutionFolder $projectName)
        
        $result = dotnet build --configuration $target /flp:v=m /flp:logfile=$logBuildFile
        $errorState = $?
        
        $timeBuild.Stop()
                
        if($errorState)
        {
            #Write-Host "Success" -ForegroundColor green
        }
        else
        {
            ii $logBuildFile # Open the log file when error
            #INFO: Write-Host "Failed" -ForegroundColor red
        }
        
        #INFO: Write-Host (Get-Content $logBuildFile | select -last 4 | select -first 2)
        #INFO: Write-Host
        
        Add-Content -Path $_logExecutionTime -Value ("    |- {0} elapsed {1} seconds" -f $projectName, $timeBuild.Elapsed.TotalSeconds)        
        Add-Content -Path $_logExecutionTime -Value ""
        Add-Content -Path $_logExecutionTime -Value (Get-Content $logBuildFile | select -last 4 | select -first 2)
        Add-Content -Path $_logExecutionTime -Value ""
        
        return $errorState
    }
}

Function PublishProject
{
    [cmdletbinding()]
    param (
        [Parameter(Mandatory=$True, HelpMessage='What is the solution folder ?')]
        [Alias("sf")]
        [string]$solutionFolder,
        [Parameter(Mandatory=$True, HelpMessage='What is the solution name you want to build ?')]
        [Alias("pn")]
        [string]$projectName,
        [Parameter(Mandatory=$True, HelpMessage='What is the target of the build ?')]
        [Alias("t")]
        [string]$target,
        [Parameter(Mandatory=$True, HelpMessage='What is the folder of build logs ?')]
        [Alias("lbf")]
        [string]$_logBuildFolder,
        [Parameter(Mandatory=$True, HelpMessage='What is the full path of the execution time log ?')]
        [Alias("let")]
        [string]$_logExecutionTime
    )
    
    process
    {
        $logBuildFile = "{0}\{1}_publish.log" -f $_logBuildFolder, $projectName
        
        $timeBuild = [System.Diagnostics.Stopwatch]::StartNew()
        Push-Location
        cd (Join-Path $solutionFolder $projectName)
        
        $result = dotnet publish --configuration $target /flp:v=m /flp:logfile=$logBuildFile
        $errorState = $?
        
        $timeBuild.Stop()
                
        if($errorState)
        {
            #Write-Host "Success" -ForegroundColor green
        }
        else
        {
            ii $logBuildFile # Open the log file when error
            #INFO: Write-Host "Failed" -ForegroundColor red
        }
        
        #INFO: Write-Host (Get-Content $logBuildFile | select -last 4 | select -first 2)
        #INFO: Write-Host
        
        Add-Content -Path $_logExecutionTime -Value ("    |- {0} elapsed {1} seconds" -f $projectName, $timeBuild.Elapsed.TotalSeconds)        
        Add-Content -Path $_logExecutionTime -Value ""
        Add-Content -Path $_logExecutionTime -Value (Get-Content $logBuildFile | select -last 4 | select -first 2)
        Add-Content -Path $_logExecutionTime -Value ""
        
        return $errorState
    }
}

Function LaunchPhase
{
    [cmdletbinding()]
    param (
        [Parameter(Mandatory=$True, HelpMessage='What is the phase Id ?')]
        [Alias("id")]
        [int]$phaseId,
        [Parameter(Mandatory=$True, HelpMessage='What is the phase to launch ?')]
        [Alias("p")]
        [system.array]$phase,
        [Parameter(Mandatory=$True, HelpMessage='What is the project folder ?')]
        [Alias("pf")]
        [string]$projectFolder,
        [Parameter(Mandatory=$True, HelpMessage='What is the target of the build ?')]
        [Alias("t")]
        [string]$target,
        [Parameter(Mandatory=$True, HelpMessage='What is the folder of build logs ?')]
        [Alias("lbf")]
        [string]$_logBuildFolder,
        [Parameter(Mandatory=$True, HelpMessage='What is the full path of the execution time log ?')]
        [Alias("let")]
        [string]$_logExecutionTime,
        [Parameter(Mandatory=$True, HelpMessage='What is the OTHER_DEV folder containing CommonBuild powershell script ?')]
        [Alias("odf")]
        [string]$otherDevFolder,
        [Parameter(Mandatory=$False, HelpMessage='What is the special step to launch ?')]
        [Alias("speStep")]
        [system.array]$specialStep,
        [Parameter(Mandatory=$False, HelpMessage='What are the projects to publish ?')]
        [Alias("pp")]
        [system.array]$projectPublish,
        [Parameter(Mandatory=$False, HelpMessage='Do we generate the BOM file ?')]
        [Alias("bom")]
        [bool]$generateBom
    )
    
    process 
    {        
        $guid = [guid]::NewGuid()
        $continue = $true
        $jobPhaseSteps = @()
        
        foreach($step in $phase)
        {
            if(($step -is [system.array]) -and $continue) {
                Write-Host ("           {0}" -f ($step -join ', '))
                $jobPhaseSteps += Start-Job -Name $jobName -ArgumentList $step, $projectFolder, $target, $_logBuildFolder, $_logExecutionTime, $otherDevFolder, $global:buildProjectsArr, $global:buildWebsitesArr, $projectPublish, $generateBom -ScriptBlock {
                    [cmdletbinding()] 
                    param($step, $projectFolder, $target, $_logBuildFolder, $_logExecutionTime, $otherDevFolder, $buildProjectsArr, $buildWebsitesArr, $projectPublish, $generateBom)
                    
                    . (Join-Path $otherDevFolder "_BUILD\PowershellCommonScripts\Common.ps1")
                    . (Join-Path $otherDevFolder "_BUILD\PowershellCommonScripts\CommonBuild.ps1")
                                        
                    $success = $True
                    foreach($project in $step) {
                        if(-not($project -is [system.array])) {
                            # BUILD PROJECT WITH DOTNET but if one FAILED to avoid useless build
                            if($success){
                                try {                                                                   
                                    $success = BuildProject -sf $projectFolder -pn $project -t $target -lbf $_logBuildFolder -let $_logExecutionTime
									if($generateBom) {
										$solutionFileName = (ls -Path (Join-Path $projectFolder $project) -File -Filter "*.sln").Name
										dotnet-CycloneDX (Join-Path $projectFolder "$project\$solutionFileName") -o (Join-Path $env:IFSBOHOMENG "..\IFS_INTEG\Security\Bom\$project") -r 3>&1 2>&1 | Out-File (Join-Path $_logBuildFolder "BOM_$project.log")
									}
									if($projectPublish -contains $step) {
										$success = PublishProject -sf $projectFolder -pn $project -t $target -lbf $_logBuildFolder -let $_logExecutionTime										
									}
                                }
                                catch {  
                                    throw
                                }
                                        
                                if(-not($success)) { 
                                    throw("Build of $project not succeed") #Report the failure and Job will appear Failed
                                }
                            }
                        }
                    }
                    Write-Host ("           Finished {0} " -f ($step -join ', ')) -ForegroundColor green
                }
            }
            else
            {     
                if(-not($specialStep -contains $step) -and (($specialStep | Measure).Count -gt 0)) { 
                    $continue = $false
                }
                else {
                    $continue = $true
                    $jobName = "Phase{0}Step{1}" -f $phaseId, $step    
                    if(($specialStep | Measure).Count -gt 0){ $retry = "[RETRY] "; }
                    else { $retry = ""; }
                     
                    Write-Verbose "     > $guid"
                    Write-Color "     > ", ("{0}" -f $retry), "Step $step" -C White, Yellow, Cyan
                }
            }
        }
                 
        Get-Job -name ("Phase{0}*" -f $phaseId) | Wait-Job | ? { $_.State -eq 'Completed' } | Sort-Object Name | Receive-Job
        
        $result = $true
        Get-Job -name ("Phase{0}*" -f $phaseId) | Wait-Job | ? { $_.State -eq 'Failed' } | % {
            $stepIndex = $_.Name.Substring($_.Name.LastIndexOf("Step")+4)
            $answer = Get-BoolChoice ("         Do you want to retry the phase {0} ?" -f $phaseId) -defaultValue "y"
            if($answer) {
                Get-Job -name $_.Name | Remove-Job
                $result = LaunchPhase -id $phaseId -p $phase -speStep $stepIndex -pf $projectFolder -t $target -lbf $_logBuildFolder -let $_logExecutionTime -odf $otherDevFolder
            }
            else
            {
                Write-Host ("         Failure ($guid) {0}" -f ($step -join ', ')) -ForegroundColor darkred            
                $result = $false
            }
        }
        
        return $result
    }
}