#Connecting to the Linux server

$users = Get-LocalUser
foreach ($user in $users){
    if($user.Enabled -eq "True"){
    $yesno =Read-Host "Do you want to try and connect",$user,"? (Y or N)"
    if($yesno -eq "Y" -or $yesno -eq "y"){
        $ip = Read-Host "What is the IP address of your Linux server?"
        New-SSHSession -ComputerName $ip 
    }
   }
}
