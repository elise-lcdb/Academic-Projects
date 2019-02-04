#Restore Files from the backups we had done

$path = Read-Host "What is the Path to your file?"
$bkp = Import-Csv -Path $path -Delimiter ";"

Foreach ($backup in $bkp){
    $source = $backup.'repertoire_source'
    $destination = $backup.'repertoire_destination'
    $yesno = Read-Host "Would you like to restore the folder:",$source,"(Y or N)"
    if($yesno -eq "Y" -or $yesno -eq "y"){
        $zips = Get-ChildItem $destination | Where-Object{$_.Extension -eq ".zip"}
        foreach($zip in $zips){
          Write-Host "The zip:",$zip,"was found in the folder where you asked to save the backup of",$source
          $yesno = Read-Host "Would you like to use this zip to restore",$source,"? (Y or N)"

          if($yesno -eq "Y" -or $yesno -eq "y"){
            $destpath = $destination+'\'+$zip
            Remove-Item -Path $source
            Expand-Archive -Path $destpath -DestinationPath $source
          }
        }
    }
}