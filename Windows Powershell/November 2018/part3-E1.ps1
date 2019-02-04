
#Get the path to the backup 
$path = Read-Host "What is the Path to your file?"
$bkp = Import-Csv -Path $path -Delimiter ";"

#Listing the backups available
Write-Host "The backups avaible are:"
foreach($backup in $bkp){
    $source = $bkp."repertoire_destination"
    $destination = $bkp."repertoire_destination"
    Write-Host "Source of the backup: ",$source, " and the destination of that backup: ",$destination 
}
