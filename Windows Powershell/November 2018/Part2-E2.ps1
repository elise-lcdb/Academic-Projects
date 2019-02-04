#Adding SSH access
Write-Host "1 - Would you like to enabled a disabled user in linux?"
$answer = Read-Host "2 -Would you like to add an account on the linux server? "
if($answer -eq 1){
    $ip = Read-Host "What is the IP address of your Linux server?"
    $ssh = New-SSHSession -ComputerName $ip
    Write-Host "First we need to connect to sudo"
    $sudo = Read-Host "What is your linux password?"
    $name = Read-Host "What is the username of the user you want to enable?"
    $command = "echo "+$sudo+" | sudo -S passwd -u "+$name
    Invoke-SSHCommand -SSHSession $ssh -Command $command
}

if($answer -eq 2){
    $ip = Read-Host "What is the IP address of your Linux server?"
    $ssh = New-SSHSession -ComputerName $ip
    Write-Host "First we need to connect to sudo"
    $sudo = Read-Host "What is your linux password?"
    $name = Read-Host "What is the username of the new user?"
    $passwd = Read-Host "What is the password of the new user?"
    $command = "echo "+$sudo+" | sudo -S useradd -m "+$name+" -p "+$passwd
    Invoke-SSHCommand -SSHSession $ssh -Command $command
}