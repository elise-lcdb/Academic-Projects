$users = Get-LocalUser
Foreach ($user in $users){
    $user = Get-LocalUser -Name $user 
    $fullname = $user.FullName
    $description = $user.Description
    if ($fullname -eq ''){
        Write-Host "The user:",$user, "has no fullname"
    }
    if ($fullname -ne ''){
        Write-Host "The user:",$user, "has the full name: ",$fullname
    }
    if ($description -eq ''){
        Write-Host "The user:",$user, "has no description"
    }
    if ($description -ne ''){
        Write-Host "The user:",$user, "has the description:",$description
    }
    $yesno = Read-Host "Would you like to modify the fullname, description, or password of the user: ", $user,"?  Y (yes), N (no)"
    if ($yesno -eq "Y" -or $yesno -eq "y"){
        Write-Host "OK"
        $yesno = Read-Host "Would you like to modify the fullname?"
        if($yesno -eq "Y" -or $yesno -eq "y"){
            $fname = Read-Host "Enter the desired full name"
            Set-LocalUser -Name $user -FullName $fname
        }
        $yesno = Read-Host "Would you like to modify the description?"
        if($yesno -eq "Y" -or $yesno -eq "y"){
            $desc = Read-Host "Enter the desired description"
            Set-LocalUser -Name $user -Description $desc
        }
        $yesno = Read-Host "Would you like to modify the password?"
        if($yesno -eq "Y" -or $yesno -eq "y"){
            #The next two lines resemble closely to the official Microsoft documentation on Set-LocalUser example on updating passwords
            $password = Read-Host "Enter the desired password" -AsSecureString
            Set-LocalUser -Name $user -Password $password
        }
    }
}
