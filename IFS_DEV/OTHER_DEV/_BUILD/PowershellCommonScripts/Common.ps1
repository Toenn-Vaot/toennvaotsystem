import-module WebAdministration #Add the module to administrate IIS

Function Set-Shortcut()
{
    <#
      .SYNOPSIS
      Function to create/set shortcut
      .DESCRIPTION
      This function create/set shortcut at $DestinationPath for $SourceExe
      .EXAMPLE
      Set-ShortCut("X:\service.exe", "$Home\Desktop\Service.lnk")
      .PARAMETER SourceExe
      The executable path to shortcut
      .PARAMETER DestinationPath
      The destination path of shortcut
    #>
    [CmdletBinding()]
    param (
        [Parameter(Mandatory=$True, HelpMessage='What is the executable source path ?')]
		[Alias("s")]
        [string]$SourceExe,
        [Parameter(Mandatory=$True, HelpMessage='What is the destination shortcut path ?')]
		[Alias("d")]
        [string]$DestinationPath,
        [Parameter(Mandatory=$False, HelpMessage='What are the optional executable arguments ?')]
		[Alias("args")]
        [string]$Arguments = $null,
        [Parameter(Mandatory=$False, HelpMessage='What are the working directory (default is the directory of SourceExe) ?')]
		[Alias("wd")]
        [string]$WorkingDirectory = $null
    )
    begin {
    }
    process {
        $WshShell = New-Object -comObject WScript.Shell
        if(-not $DestinationPath.EndsWith(".lnk")) {
            $DestinationPath = "$($DestinationPath).lnk"
        }
        $Shortcut = $WshShell.CreateShortcut($DestinationPath)
        $Shortcut.TargetPath = $SourceExe
        if($WorkingDirectory -ne $null) {
            $Shortcut.WorkingDirectory = Split-Path($SourceExe)
        } else {
            $Shortcut.WorkingDirectory = $WorkingDirectory
        }

        if($Arguments -ne $null) {
            $Shortcut.Arguments = $Arguments
        }
        $Shortcut.Save()
    }
}

Function InstallService()
{
    <#
      .SYNOPSIS
      Function to install windows service thanks to INSTALLUTIL.EXE
      .DESCRIPTION
      This function install service provided in parameter $serviceExecutablePath
      .EXAMPLE
      InstallService("X:\service.exe")
      .PARAMETER serviceExecutablePath
      The service executable path to install
    #>
    [CmdletBinding()]
    param (
        [Parameter(Mandatory=$True, HelpMessage='What is the service name to install ?')]
		[Alias("n")]
        [string]$serviceName,
        [Parameter(Mandatory=$True, HelpMessage='What is the service executable path to install ?')]
		[Alias("sep")]
        [string]$serviceExecutablePath,
        [Parameter(Mandatory=$True, HelpMessage='What is the log folder path for un/install result ?')]
		[Alias("lf")]
        [string]$logFile,
        [Parameter(Mandatory=$False, HelpMessage='What is the architecture used to install ?')]
		[Alias("x86")]
        [bool]$architectureX86 = $True,
        [Parameter(Mandatory=$False, HelpMessage='Do you want uninstall ONLY ?')]
		[Alias("u")]
        [bool]$uninstall = $False
    )
	
	begin {
    }
    
    process {
		if($architectureX86) {
			$rtd = Join-Path $env:windir "Microsoft.NET\Framework\v4.0.30319"
		} else {
			$rtd = [System.Runtime.InteropServices.RuntimeEnvironment]::GetRuntimeDirectory()
		}
		$installUtil = Join-Path $rtd "installutil.exe"
		
		Write-Host "    |- $serviceName"
		Write-Host "       |- Uninstall" -ForegroundColor Red
		$installService = Start-Process $installUtil -PassThru -ArgumentList "-u", $serviceExecutablePath, "/LogFile="
        $installService.WaitForExit()
        
        if(-not $uninstall){
		    Write-Host "       |- Install" -ForegroundColor Green
		    $uninstallService = Start-Process $installUtil -PassThru -ArgumentList $serviceExecutablePath, "/LogFile="
            $uninstallService.WaitForExit()

		    Write-Host "       |- Check" -ForegroundColor Gray
		    if((Get-Service -Name $serviceName | Measure-Object).Count -eq 1)
            {            
		        Write-Host "          |--- Succeed" -ForegroundColor Green
            } else {
                Write-Host "          |--- Failed" -ForegroundColor Red
            }
        }
    }
}

Function KillingDependingProcesses()
{
    <#
      .SYNOPSIS
      Function to kill depending processes which lock files updated during the build
    #>
    begin{}
    
    process{        
        $dependingProcesses = "w3wp.exe"
        KillingProcesses($dependingProcesses)
    }
}

Function KillingProcesses()
{
    <#
      .SYNOPSIS
      Function to kill processes provided
      .EXAMPLE
      KillingProcesses -pl "Process1", "Process2"
      .PARAMETER processList
      The list of process names
    #>
    [CmdletBinding()]
    param (
        [Parameter(Mandatory=$True, HelpMessage='What is the list of process to kill ?')]
		[Alias("pl")]
        [string[]]$processList
    )
    begin{}
    
    process{        
        Get-Process | ? { $processList -contains $_.Name } | Stop-Process -Force -ErrorAction "SilentlyContinue"
    }
}

Function StopDependingServices()
{
    <#
      .SYNOPSIS
      Function to kill depending services which lock files updated during the build
    #>
    begin{}
    
    process{
        $dependingServices = "AOS60$01", "BCC.NTService", "BCM.x86.Service", "EOD.Agent.NET", "EOD.Manager.NET", "Smc.Gw.Level3.ServiceNT", "DCP_InserterService_1", "DCP_DataRecoveryService", "DCP.LogBook.Service", "DCP.SpecialEvent.Service", "RDBM_REQM", "REM", "RSYS_AM", "WksEmitter", "RSysLnkCns", "KeyData", "EQMService", "SEC.SALManager", "RSysLogger", "DataCardCorrection"
        get-service -Include $dependingServices | Stop-Service
    }
}

Function WaitServiceStatus(){    
    <#
      .SYNOPSIS
      Function to wait services since they are in required status
      .EXAMPLE
      WaitServiceStatus -sl "Services1", "Services1" -st Running
      .PARAMETER servicesList
      The list of service names
      .PARAMETER status
      The status to wait
    #>
    [CmdletBinding()]
    param (
        [Parameter(Mandatory=$True, HelpMessage='What is the list of services to wait status?')]
		[Alias("sl")]
        [string[]]$servicesList,
        [Parameter(Mandatory=$True, HelpMessage='What is the status to wait?')]
        [Alias("st")]
        [System.ServiceProcess.ServiceControllerStatus]$status
    )
    begin{}

    process {
        $maxRepeat = 20
        do 
        {
            $count = (Get-Service $services | ? {$_.Status -eq $status}).Count
            $maxRepeat--
            sleep -Milliseconds 200
        } until ($count -eq 0 -or $maxRepeat -eq 0)
    }
}

Function Get-BoolChoice
{
    <#
      .SYNOPSIS
      Function to get the boolean choice of the user about a question
      .DESCRIPTION
      This function ask the question to the user and wait the choice of the user between 'y' ($true) and 'n' ($false).
      When the user choices a right option, the function returns the boolean choice : True ($true) if it is 'y', 
      False ($false) if it is 'n'
      .EXAMPLE
      Get-BoolChoice("Do you want to continue [y/n] ?")
      .PARAMETER question
      The question asked to the user
      .OUTPUTS
      System.Boolean. Get-BoolChoice return the bool equivalent of the user choice. True ($true) if the user choice 'y', otherwise False ($false)
    #>
    [CmdletBinding()]
    param (
        [Parameter(Mandatory=$True, HelpMessage='What is the question you want to ask ?')]
        [string]$question,
        [Parameter(Mandatory=$False, HelpMessage='What is the default value if user just hit Enter ?')]
        [ValidatePattern("[ynYN]")]
        [string]$defaultValue
    )
    
    begin {
    }
    
    process {
        $yes = New-Object System.Management.Automation.Host.ChoiceDescription "&Yes", "Yes"
        $no = New-Object System.Management.Automation.Host.ChoiceDescription "&No", "No"
        
        $options = [System.Management.Automation.Host.ChoiceDescription[]]($yes, $no)
        if(@("y", "Y") -contains $defaultValue) { $default = 0 } else { $default = 1 }
        $result = $host.ui.PromptForChoice("", $question, $options, $default)
        Write-Verbose ("The bool choice : {0}" -f $result)
        
        return ($result -eq 0)
    }
}

Function Get-TargetChoice
{
    <#
      .SYNOPSIS
      Function to get the target choice of the user about a question
      .DESCRIPTION
      This function ask the question to the user and wait the choice of the user between '0' (Debug) and '1' (Release).
      When the user choices a right option, the function returns the target string resulting : Debug if it is '0', 
      Release if it is '1'
      .EXAMPLE
      Get-BoolChoice("What the target [0-Debug] / [1-Release] ?")
      .PARAMETER question
      The question asked to the user
      .OUTPUTS
      System.String. Get-TargetChoice return the target string resulting of the user choice. Debug if the user choice '0', otherwise Release ('1')
    #>
    [CmdletBinding()]
    param (        
        [Parameter(Mandatory=$True, HelpMessage='What is the question you want to ask ?')]
        [string]$question
    )
    
    begin {}
    
    process {
        $targetsArr = "Debug","Release"        
        
        $debug = New-Object System.Management.Automation.Host.ChoiceDescription "&0_Debug", "Build in DEBUG mode"
        $release = New-Object System.Management.Automation.Host.ChoiceDescription "&1_Release", "Build in RELEASE mode"
        
        $options = [System.Management.Automation.Host.ChoiceDescription[]]($debug, $release)
        $result = $host.ui.PromptForChoice("", $question, $options, 0)
        Write-Verbose ("The target choice : {0}" -f $result)
        Write-Verbose ("corresponding to : {0}" -f $targetsArr[$result])
        
        return $targetsArr[$result]
    }
}

Function RegisterDllServer
{
    <#
      .SYNOPSIS
      Register a dll in the system thanks to regsvr32
    #>
    [CmdletBinding()]
    param(
        [Parameter(Mandatory=$True, HelpMessage='What is the DLL you want to register ?')]
        [Alias("dll")]
        [string]$dllPath,
        [Alias("u")]
        [bool]$uninstall = $false,
        [Alias("s")]
        [bool]$silent = $true,
        [Alias("ub")]
        [bool]$uninstallBefore = $false
    )
    
    begin {}
    
    process {      
        $arguments = $dllPath
        if($silent) { $arguments = $arguments + " /s" }
        if($uninstall) { $arguments = $arguments + " /u" }
    
        if(Test-Path $dllPath)
        {
            if($uninstallBefore -and (-not $uninstall))
            {
                Write-Host "      |- $dllPath" -ForegroundColor Gray
                RegisterDllServer -dll $dllPath -s $silent -u $true
            }
                        
            $process = New-Object System.Diagnostics.Process
            $startInfo = New-Object System.Diagnostics.ProcessStartInfo
            
            $startInfo.FileName = Join-Path ([Environment]::SystemDirectory) "regsvr32.exe"
            $startInfo.Arguments = $arguments
            
            $process.StartInfo = $startInfo
            if(-not $uninstall)
            {                
                "         |- Install"
            }
            else
            {
                Write-Host "         |- Uninstall" -ForegroundColor Red
            }
            $result = $process.Start()            
            $process.WaitForExit() | Out-Null
            
            [int]$exitCode = $process.ExitCode
            $process.Dispose()
            
            switch($exitCode)
            {
                0 { Write-Host "            |--- Succeed" -ForegroundColor green }
                1 { Write-Host "            |-- Failed (Wrong arguments)" -ForegroundColor darkred }
                2 { Write-Host "            |-- Failed (OLE Initialization)" -ForegroundColor darkred }
                3 { Write-Host "            |-- Failed (Dependencies)" -ForegroundColor darkred }
                4 { 
                    if($uninstall) { Write-Host "            |-- Failed (DllUnregisterServer point not found)" -ForegroundColor darkred }
                    else { Write-Host "            |-- Failed (DllRegisterServer point not found)" -ForegroundColor darkred }
                }
                5 { Write-Host "            |-- Failed (DllRegisterServer call)" -ForegroundColor darkred }
                default { Write-Host ("            |-- Failed ({0})" -f $exitCode) -ForegroundColor darkred }
            }
            
            if(-not $silent)
            {
                return $exitCode
            }
        }
        else
        {
            Write-Host ("            |-- Failed (Path doesn't exists [{0}])" -f $dllPath) -ForegroundColor darkred
            if(-not $silent)
            {
                return 3
            }
        }
    }
}
Set-Alias RegSvr32 RegisterDllServer

Function RegisterAssembly()
{
    <#
      .SYNOPSIS
      Function to register assembly thanks to REGASM.EXE
      .DESCRIPTION
      This function register the assembly specified in parameter $assemblyPath
      .EXAMPLE
      RegisterAssembly("X:\assembly.dll")
      .PARAMETER assemblyPath
      The assembly path to register
    #>
    [CmdletBinding()]
    param (
        [Parameter(Mandatory=$True, HelpMessage='What is the assembly name to register ?')]
		[Alias("n")]
        [string]$assemblyName,
        [Parameter(Mandatory=$True, HelpMessage='What is the assembly path to register ?')]
		[Alias("ap")]
        [string]$assemblyPath,
        [Parameter(Mandatory=$False, HelpMessage='What is the architecture used to install ?')]
		[Alias("x86")]
        [bool]$architectureX86 = $True,
        [Parameter(Mandatory=$False, HelpMessage='Do you want uninstall ONLY ?')]
		[Alias("u")]
        [bool]$uninstall = $False
    )
	
	begin {
    }
    
    process {
		if($architectureX86) {
			$rtd = Join-Path $env:windir "Microsoft.NET\Framework\v4.0.30319"
		} else {
			$rtd = [System.Runtime.InteropServices.RuntimeEnvironment]::GetRuntimeDirectory()
		}
		$regasm = Join-Path $rtd "regasm.exe"
		
		Write-Host ("      |- {0}" -f $assemblyName) -ForegroundColor Gray
		#Write-Host ("       |- INFO ! Using tool path : {0}" -f $rtd) -ForegroundColor Cyan
		Write-Host "         |- Uninstall" -ForegroundColor Red
		$pUninstall = Start-Process $regasm -PassThru -NoNewWindow -ArgumentList "-u", "/nologo", $assemblyPath
        $pUninstall.WaitForExit()

        if(-not $uninstall){
		    Write-Host "         |- Install" -ForegroundColor Green
		    $pInstall = Start-Process $regasm -PassThru -NoNewWindow -ArgumentList "/codebase", "/nologo", $assemblyPath
            $pInstall.WaitForExit()
        }
    }
}
Set-Alias RegAsm RegisterAssembly

Function RegisterExecutable()
{
    <#
      .SYNOPSIS
      Function to register executable thanks to REGASM.EXE
      .DESCRIPTION
      This function register the executable specified in parameter $executablePath
      .EXAMPLE
      RegisterExecutable("X:\executable.exe")
      .PARAMETER assemblyPath
      The assembly path to register
    #>
    [CmdletBinding()]
    param (
        [Parameter(Mandatory=$True, HelpMessage='What is the executable name to register ?')]
		[Alias("n")]
        [string]$executableName,
        [Parameter(Mandatory=$True, HelpMessage='What is the executable path to register ?')]
		[Alias("ep")]
        [string]$executablePath,
        [Parameter(Mandatory=$False, HelpMessage='What is the architecture used to install ?')]
		[Alias("x86")]
        [bool]$architectureX86 = $True,
        [Parameter(Mandatory=$False, HelpMessage='Do you want uninstall ONLY ?')]
		[Alias("u")]
        [bool]$uninstall = $False
    )
	
	begin {
    }
    
    process {
		if($architectureX86) {
			$rtd = Join-Path $env:windir "Microsoft.NET\Framework\v4.0.30319"
		} else {
			$rtd = [System.Runtime.InteropServices.RuntimeEnvironment]::GetRuntimeDirectory()
		}
		$regasm = Join-Path $rtd "regasm.exe"
		
		Write-Host ("      |- {0}" -f $executableName) -ForegroundColor Gray
		#Write-Host ("       |- INFO ! Using tool path : {0}" -f $rtd) -ForegroundColor Cyan
		Write-Host "         |- Uninstall" -ForegroundColor Red
		$pUninstall = Start-Process $regasm -PassThru -ArgumentList "/unregister", "/tlb", $executablePath
        $pUninstall.WaitForExit()
        
        if($uninstall) {
		    Write-Host "         |- Install" -ForegroundColor Green
		    $pInstall = Start-Process $regasm -PassThru -ArgumentList "/register", "/tlb", $executablePath
            $pInstall.WaitForExit()
        }
    }
}
Set-Alias RegExe RegisterExecutable

Function RegisterServer()
{
    <#
      .SYNOPSIS
      Function to register executable with embedded registration functions
      .DESCRIPTION
      This function register the executable specified in parameter $executablePath
      .EXAMPLE
      RegisterServer("X:\executable.exe")
      .PARAMETER executablePath
      The server executable to register
    #>
    [CmdletBinding()]
    param (
        [Parameter(Mandatory=$True, HelpMessage='What is the server executable name to register ?')]
		[Alias("n")]
        [string]$executableName,
        [Parameter(Mandatory=$True, HelpMessage='What is the server executable path to register ?')]
		[Alias("ep")]
        [string]$executablePath,
        [Parameter(Mandatory=$False, HelpMessage='Do you want uninstall ONLY ?')]
		[Alias("u")]
        [bool]$uninstall = $False
    )
	
	begin {
    }
    
    process {		
		Write-Host ("      |- {0}" -f $executableName) -ForegroundColor Gray
		Write-Host "         |- Uninstall" -ForegroundColor Red
		&$executablePath /UnregServer
        Sleep 1
        if(-not $uninstall){
		    Write-Host "         |- Install" -ForegroundColor Green
            &$executablePath /RegServer
            Sleep 1
        }
    }
}
Set-Alias RegServerExe RegisterServer

Function RegisterService()
{
    <#
      .SYNOPSIS
      Function to register service with embedded registration functions
      .DESCRIPTION
      This function register the service specified in parameter $servicePath
      .EXAMPLE
      RegisterService("X:\service1.exe")
      .PARAMETER servicePath
      The service executable to register
    #>
    [CmdletBinding()]
    param (
        [Parameter(Mandatory=$True, HelpMessage='What is the service name to register ?')]
		[Alias("n")]
        [string]$serviceName,
        [Parameter(Mandatory=$True, HelpMessage='What is the service executable path to register ?')]
		[Alias("sp")]
        [string]$servicePath,
        [Parameter(Mandatory=$False, HelpMessage='Do you want uninstall ONLY ?')]
		[Alias("u")]
        [bool]$uninstall = $False
    )
	
	begin {
    }
    
    process {		
		Write-Host ("      |- {0}" -f $serviceName) -ForegroundColor Gray
		Write-Host "         |- Uninstall" -ForegroundColor Red
		sc.exe delete $serviceName | Out-Null
        Sleep 1
        if(-not $uninstall){
		    Write-Host "         |- Install" -ForegroundColor Green
            &$servicePath /Service
            Sleep 1
        }
    }
}
Set-Alias RegService RegisterService

Function InstallAsCom+(){
    [CmdletBinding()]
    param (
        [Parameter(Mandatory=$True, HelpMessage='What is the application COM+ name ?')]
		[Alias("an")]
        [string]$appName,
        [Parameter(Mandatory=$True, HelpMessage='What is the application COM+ description ?')]
		[Alias("ad")]
        [string]$appDesc,
        [Parameter(Mandatory=$True, HelpMessage='What is the application COM+ dll ?')]
		[Alias("adll")]
        [string]$appDll,
        [Parameter(Mandatory=$True, HelpMessage='What is the application COM+ directory ?')]
		[Alias("adir")]
        [string]$appDirectory
    )

    begin {
        $comAdmin = New-Object -comobject COMAdmin.COMAdminCatalog
        $apps = $comAdmin.GetCollection("Applications")
        $apps.Populate();

        $appFound = $false
        foreach ($app in $apps ) {
            if ($app.Name -eq $appName ) {
                $appFound = $true
                #break
            }
        }
        if (!($appFound )) {
            $app = $apps.Add()
            $app.Value("Name") = $appName
            $app.Value("Description") = $appDesc
            $app.Value("ApplicationDirectory") = $appDirectory
            $app.Value("ApplicationAccessChecksEnabled") = $False
	        $app.Value("DumpEnabled") = 1
	        $app.Value("DumpOnException") = 1
	        $app.Value("DumpOnFailfast") = 1
	        $app.Value("DumpPath") = "%IFSBOHOME%\Log"
	        $app.Value("MaxDumpCount") = 10

            $apps.SaveChanges();

            $comAdmin.CreateServiceForApplication($appName, $appName, "SERVICE_DEMAND_START", "SERVICE_ERROR_NORMAL", "", ".\localsystem", "", 0)
            $comAdmin.InstallComponent($appName, $appDll, '', '')

            $comAdmin.U

            $errorInfo = $comAdmin.GetCollection("ErrorInfo")
            $errorInfo.Populate()
            $errorCode = $errorInfo.Item(0).Value("ErrorCode")            

            if($errorCode -eq -2146368476) {
                Write-Host "   |- Installed" -ForegroundColor Green
            }
            else {            
                Write-Host "- Error installation component = $errorCode" -ForegroundColor Red
            }
        }
        else {
            Write-Host "   |-- $appName already exists, skipping" -ForegroundColor Cyan
        }
    }
}

Function RemoveCom+(){
    [CmdletBinding()]
    param (
        [Parameter(Mandatory=$True, HelpMessage='What is the application COM+ name ?')]
		[Alias("an")]
        [string]$appName,
        [Parameter(Mandatory=$True, HelpMessage='What is the application COM+ description ?')]
		[Alias("ad")]
        [string]$appDesc,
        [Parameter(Mandatory=$True, HelpMessage='What is the application COM+ dll ?')]
		[Alias("adll")]
        [string]$appDll,
        [Parameter(Mandatory=$True, HelpMessage='What is the application COM+ directory ?')]
		[Alias("adir")]
        [string]$appDirectory
    )

    begin {
        $comAdmin = New-Object -comobject COMAdmin.COMAdminCatalog
        $apps = $comAdmin.GetCollection("Applications")
        $apps.Populate();

        $index = 0
        $appFound = $False
        foreach ($app in $apps ) {
            if ($app.Name -eq $appName ) {
                $apps.Remove($index) | Out-Null
                $apps.SaveChanges() | Out-Null
                $appFound = $True
                #break
            }
            $index++
        }
        if (!($appFound )) {
            Write-Host "   |-- $appName doesn't exists, skipping" -ForegroundColor Cyan            
        }
        else {
            Write-Host "   |-- $appName (COM+) removed" -ForegroundColor Green
        }
    }
}

Function AddOrSetRegistryKey()
{
    [CmdletBinding()]
    param (
        [Parameter(Mandatory=$True, HelpMessage='What is the key name to add or set ?')]
		[Alias("kn")]
        [string]$keyName,
        [Parameter(Mandatory=$True, HelpMessage='What is the key path to add or set ?')]
		[Alias("kp")]
        [string]$keyPath,
        [Parameter(Mandatory=$True, HelpMessage='What is the key value to add or set ?')]
		[Alias("kv")]
        [object]$keyValue
    )
	
    begin {

        Write-Host "   Registry" -ForegroundColor Gray
        Write-Host ("     |- {0}\{1} (value: {2})" -f $keyPath, $keyName, $keyValue) -ForegroundColor Yellow
        if((Get-ItemProperty -Path $keyPath -Name $keyName | Measure-Object).Count -eq 1) {
            Write-Host "       |- Updating value" -ForegroundColor Green
            Set-ItemProperty -Path $keyPath -Name $keyName -Value $keyValue
        }
        else {
            Write-Host "       |- Adding value" -ForegroundColor Green
            New-ItemProperty -Path $keyPath -Name $keyName -Value $keyValue
        }
    }
}

Function PropagateEnvironmentChange
{
    process
    {
        if(-not ("Win32.NativeMethods" -as [Type])){
            #Import SendMessageTimeout from Win32 library
            Add-Type -Namespace Win32 -Name NativeMethods -MemberDefinition @"
                [DllImport("user32.dll", SetLastError=true, CharSet=CharSet.Auto)]
                public static extern IntPtr SendMessageTimeout(
                    IntPtr HWind, uint Msg, UIntPtr wParam, string lParam,
                    uint fuFlags, uint uTimeout, out UIntPtr lpdwResult);
"@
        }

        $HWND_BROADCAST = [IntPtr]0xffff;
        $WM_SETTINGCHANGE = 0x1a;
        $result = [UIntPtr]::Zero

        return [Win32.NativeMethods]::SendMessageTimeout($HWND_BROADCAST, $WM_SETTINGCHANGE, [UIntPtr]::Zero, "Environment", 2, 5000, [ref]$result)
    }
}

Function Set-FileAttribute
{
    param (
        [Parameter(Mandatory=$True, HelpMessage='What is the path of the file ?')]
        [Alias("fp")]
        [string]$filePath,
        [Parameter(Mandatory=$True, HelpMessage='What is the attribute to set ?')]
        [Alias("att")]
        [System.IO.FileAttributes]$attribute
    )

    begin {}
    
    process {
        $file = gci -path $filePath -force
        $files | foreach { $_.Attributes = $_.Attributes -bor $attribute.Value__ }
        if($?) { $true } else { $false }
    }
}

Function Remove-FileAttribute
{
    param (
        [Parameter(Mandatory=$True, HelpMessage='What is the path of the file ?')]
        [Alias("fp")]
        [string]$filePath,
        [Parameter(Mandatory=$True, HelpMessage='What is the attribute to remove ?')]
        [Alias("att")]
        [System.IO.FileAttributes]$attribute
    )

    begin {}
    
    process {
        $files = gci -path $filePath -force
        $files | foreach { $_.Attributes = $_.Attributes -band (-bnot $attribute.Value__) }
        
        if($?) { $true } else { $false }
    }
}

Function CreateShortcut
{
    <#
      .SYNOPSIS
      Create a shorcut of a software on the desktop
    #>
    param (
        [Parameter(Mandatory=$True, HelpMessage='What is the name of the shorcut you want ?')]
        [Alias("sn")]
        [string]$shorcutName,
        [Parameter(Mandatory=$True, HelpMessage='What is the path of the software/command to link ?')]
        [Alias("p")]
        [string]$path        
    )
    
    begin {}
    
    process {
        $shell = New-Object -comObject WScript.Shell
        $shortcut = $shell.CreateShortcut(("$Home\Desktop\{0}.lnk" -f $shorcutName))
        $shortcut.TargetPath = $path
        $shortcut.Save()
    }
}