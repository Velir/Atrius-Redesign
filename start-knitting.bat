start powershell.exe -Command "start-process PowerShell -verb runas -ArgumentList '-noexit -Command \"Push-Location %cd%; Import-Module .\tools\powershell\Kneedle\Kneedle.psm1 -Force\"'"