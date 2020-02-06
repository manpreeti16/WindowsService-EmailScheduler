@ECHO Installing Service...
@SET PATH=%PATH%;C:\WINDOWS\Microsoft.NET\Framework\v4.0.30319\
@InstallUtil "C:\Users\mkaur1\source\repos\WindowsService1\WindowsService1\bin\Debug\SendMailWindowsService.exe"			
net start "MailEngineServiceJob"
@ECHO Install Done and service started.
@pause