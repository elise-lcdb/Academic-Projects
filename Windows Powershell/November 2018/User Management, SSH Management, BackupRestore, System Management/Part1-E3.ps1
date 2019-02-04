
$users = Get-LocalUser

foreach ($user in $users){
    $user = Get-LocalUser -Name $user 
    $enabled = $user.Enabled

    if($enabled -eq $true){
        Write-Host "The user:",$user,"is currently enabled. Would you like to disable it?"
        Write-Host "Note: Disabling a user will also disable the SSH connection to the linux server"
        $yesno = Read-Host "Y (Yes) / N (No)"
        if($yesno -eq "Y" -or $yesno -eq "y"){
            Disable-LocalUser -Name $user
            Write-Host "To disable your Linux account, please start a SSH connection"
            $ip = Read-Host "What is the IP address of your Linux server?"
            $ssh = New-SSHSession -ComputerName $ip
            Write-Host "First we need to connect to sudo"
            $sudo = Read-Host "What is your linux password?"
            $command = "echo "+$sudo+" | sudo -S passwd -l "+$user
           Invoke-SSHCommand -SSHSession $ssh -Command $command
        }
    }


}