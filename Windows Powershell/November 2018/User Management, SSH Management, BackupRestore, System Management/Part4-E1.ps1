#Testing to see if the linux server is available
#This code is from the official Microsoft Powershell Test-Connection documentation
#https://docs.microsoft.com/en-us/powershell/module/microsoft.powershell.management/test-connection?view=powershell-6
Test-Connection 10.0.2.4 -Count 1 -Quiet
