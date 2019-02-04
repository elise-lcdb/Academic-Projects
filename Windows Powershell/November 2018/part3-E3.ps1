$path = Read-Host "What is the Path to your file?"
$bkp = Import-Csv -Path $path -Delimiter ";"

$yesno = Read-Host "Would you like to start the backup?(Y or N)"

$date = Get-Date -UFormat "%Y-%m-%d_%H-%M-%S"
if($yesno -eq "Y" -or $yesno -eq "y"){
    Foreach($backup in $bkp){
    #run the backup 
    $source = $backup.'repertoire_destination'
    $destination = $backup.'repertoire_destination'
    $dest = $destination+'\'+$date+'.zip'
    Compress-Archive -Path $source -DestinationPath $dest

    }
}
