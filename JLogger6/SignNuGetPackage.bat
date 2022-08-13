@ECHO OFF
nuget.exe sign C:\Projects\JLogger\JLogger\bin\Release\Jeff.Jones.JLogger.1.0.1.nupkg -TimeStamper http://timestamp.digicert.com -CertificatePath C:\Projects\JeffJonesDigiCert.pfx -CertificatePassword Co11iez#1
pause