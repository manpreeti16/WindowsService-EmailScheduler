@ECHO UnInstalling Service...
net stop "MailEngineServiceJob"
@SET PATH=%PATH%;C:\WINDOWS\Microsoft.NET\Framework\v4.0.30319\
@InstallUtil -u "C:\Users\mkaur1\source\repos\WindowsService1\WindowsService1\bin\Debug\SendMailWindowsService.exe"
@ECHO UnInstall Done.
@pause