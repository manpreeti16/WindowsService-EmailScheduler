# WindowsService-EmailScheduler
Send configured email automatically at regular interval with help of Scheduler and Windows Service

Before running, perform following:

-Replace email id, username and password in SendMailJob.cs class to send mail.
-Configure changes in App.config to send mail at desired intervals.
-Place InstallWindowService.bat and UNInstallWindowService.bat in debug or release folder and Copy Debug or Release folder after building solution to some location.
-Replace path to exe in InstallWindowService.bat and UNInstallWindowService.bat files. 
-Install service by running the batch file.

  
