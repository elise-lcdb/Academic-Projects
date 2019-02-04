 $ip = Read-Host "What is the IP address of your Linux server?"
 $ssh = New-SSHSession -ComputerName $ip
 Write-Host "First we need to connect to sudo"
 $sudo = Read-Host "What is your linux password?"
 $name = Read-Host "What is the username of the user you want to disable?"
 $command = "echo "+$sudo+" | sudo -S passwd -l "+$name
 Invoke-SSHCommand -SSHSession $ssh -Command $command
 