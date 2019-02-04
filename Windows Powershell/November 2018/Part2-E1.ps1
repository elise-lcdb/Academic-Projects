#Connecting to the Linux server

$users = Get-LocalUser
foreach ($user in $users){
    if($user.Enabled -eq "True"){
        $ip = Read-Host "What is the IP address of your Linux server?"
        $ssh = New-SSHSession -ComputerName $ip
        #The Linux command I found is from google 
        $linuxusrs = $(Invoke-SSHCommand -SSHSession $ssh -Command "cut -d: -f1 /etc/passwd").Output
        foreach($usr in $linuxusrs){
            if($usr -eq $user){
                Write-Host "The user",$user,"has a linux account"
            }
        }


    }
}
