#I'm sorry for the code below.. I made it really complicated and I don't know why
#Changing the CSV file
$path = Read-Host "What is the Path to your file?"
$bkp = Import-Csv -Path $path -Delimiter ";"

#doubles
$rowa = 0
Foreach ($backup in $bkp){
    $source = $backup.'repertoire_source'
    $destination = $backup.'repertoire_destination'
    $rowa = $rowa + 1
    Foreach($backup2 in ($bkp | select -Skip $rowa )){
      $source2 = $backup2.'repertoire_source'
      $destination2 = $backup2.'repertoire_destination'

      if($source -eq $source2 -and $destination -eq $destination2){
        Write-Host "There is a double of the backup", $source,"and with the destination of",$destination
        #So I was going to have it delete it but the code didn't work and was a mess
        
      }
    }

}
Write-Host "The current list looks like:"
Import-Csv -Path $path -Delimiter ";"
$yesno = Read-Host "Would you like to add a row? (y or n)"
if($yesno -eq "Y" -or $yesno -eq "y"){
    $insource = Read-Host "What is the file source?"
    $indestination = Read-Host "What is the destination source?"
    Remove-Item -Path $path
    $updatedcsv = New-Object -TypeName PSCustomObject -Property @{
                  repertoire_source = $insource
                  repertoire_destination = $indestination
            }
            $updatedcsv |Add-Content -Path $path 
    foreach($backup3 in $bkp){
    $source3 = $backup3.'repertoire_source'
      $destination3 = $backup3.'repertoire_destination'
        $updatedcsv = New-Object -TypeName PSCustomObject -Property @{
                  repertoire_source = $source3
                  repertoire_destination = $destination3
            }
            $updatedcsv |Add-Content -Path $path 
    }
}

$yesno2 = Read-Host "Would you like to delete a row? (y or n)"
if($yesno2 -eq "Y" -or $yesno2 -eq "y"){
    $insource = Read-Host "What is the file source of the row you want to delete?"
    $indestination = Read-Host "What is the destination source of the row you want to delete?"
    Remove-Item -Path $path
    foreach($backup3 in $bkp){
    $source3 = $backup3.'repertoire_source'
      $destination3 = $backup3.'repertoire_destination'
      if($source3 -ne $insource -and $destination3 -ne $indestination){
        $updatedcsv = New-Object -TypeName PSCustomObject -Property @{
                  repertoire_source = $source3
                  repertoire_destination = $destination3
            }
            $updatedcsv |Add-Content -Path $path 
    }
    }
}

