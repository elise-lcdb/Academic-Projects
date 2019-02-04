
#Gets each user and shows what group they are in. Users appear multiple times as they are in multiple groups

$groups = Get-LocalGroup
$users = Get-LocalUser
 Foreach ($group in $groups){
    $member = Get-LocalGroupMember -Group $group
    Foreach ($user in $users){
        Write-Host $user, " is in ", $group, " group"  
    }
     
   }

