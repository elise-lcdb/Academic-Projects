Write-Host "When creating a new user you will need to input their username and fullname. Once that is completed a secure password will be generated for the new user"

$usrname = Read-Host "What is their username?"
$fulname = Read-Host "What is their fullname?"

#Generate a random Password for each user and export it
$psswdlength = 0
$password = $null
while ($psswdlength -lt 6) {
            $psswdlength =$psswdlength + 1
            $rand = Get-Random -Minimum 65 -Maximum 90
            $password = $password + ([char]$rand)
} 
#Numbers in Passwords
$num = Get-Random -Minimum 1 -Maximum 9
$password = $password + $num

$displaypaswd = $password

$password = $password | ConvertTo-SecureString -AsPlainText -Force

New-LocalUser -Name $usrname -FullName $fulname -Password $password

Write-Host "The user", $usrname,"has been created. And they have the password:",$displaypaswd