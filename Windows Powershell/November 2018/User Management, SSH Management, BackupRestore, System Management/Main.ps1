#Linux Server IP address 10.0.2.4
Write-Host "Welcome to the menu."
Write-Host "Please enter a number to see more options"
Write-Host "1 - User Managment"
Write-Host "2 - SSH Management"
Write-Host "3 - Backup/Restore"
$choice1 = Read-Host "4 - System Management"

if($choice1 -eq 1){
    Write-Host "1 - Show local users"
    Write-Host "2 - Modify a local user"
    Write-Host "3 - The enable or disable a user"
    $choice2 = Read-Host "4 -Add a user"
    if($choice2 -eq 1){
        $run = $PSScriptRoot+"\Part1-E1.ps1"
        &$run
    }
    if($choice2 -eq 2){
        $run = $PSScriptRoot+"\Part1-E2.ps1"
        &$run
    }
    if($choice2 -eq 3){
        $run = $PSScriptRoot+"\Part1-E3.ps1"
        &$run
    }
    if($choice2 -eq 4){
        $run = $PSScriptRoot+"\Part1-E4.ps1"
        &$run
    }
}
if($choice1 -eq 2){
    Write-Host "1 - Show local users who have an ssh connection"
    Write-Host "2 - Add ssh access"
    Write-Host "3 - Remove SSH access"
    $choice2 = Read-Host "4 - SSH connection with the choice of user"
    if($choice2 -eq 1){
        $run = $PSScriptRoot+"\Part2-E1.ps1"
        &$run
    }
    if($choice2 -eq 2){
        $run = $PSScriptRoot+"\Part2-E2.ps1"
        &$run
    }
    if($choice2 -eq 3){
        $run = $PSScriptRoot+"\Part2-E3.ps1"
        &$run
    }
    if($choice2 -eq 4){
        $run = $PSScriptRoot+"\Part2-E4.ps1"
        &$run
    }
}
if($choice1 -eq 3){
    Write-Host "1 - Show available backups"
    Write-Host "2 - Manage Backups"
    Write-Host "3 - Start a Backup"
    $choice2 = Read-Host "4 -Restore"
    if($choice2 -eq 1){
        $run = $PSScriptRoot+"\Part3-E1.ps1"
        &$run
    }
    if($choice2 -eq 2){
        $run = $PSScriptRoot+"\Part3-E2.ps1"
        &$run
    }
    if($choice2 -eq 3){
        $run = $PSScriptRoot+"\Part3-E3.ps1"
        &$run
    }
    if($choice2 -eq 4){
        $run = $PSScriptRoot+"\Part3-E4.ps1"
        &$run
    }
}
if($choice1 -eq 4){
    Write-Host "1 - Show if computer is conected to Linux Server"
     $choice2 = Read-Host "2 - Show the computer state"
    if($choice2 -eq 1){
        $run = $PSScriptRoot+"\Part4-E1.ps1"
        &$run
    }
    if($choice2 -eq 2){
        $run = $PSScriptRoot+"\Part4-E2.ps1"
        &$run
    }
}
