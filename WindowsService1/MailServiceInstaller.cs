using System.ComponentModel;
using System.ServiceProcess;

namespace SendMailWindowsService
{
    [RunInstaller(true)]
    public partial class MailServiceInstaller : System.Configuration.Install.Installer
    {        

        #region Variables

        /// <summary>
        /// Define the object of ServiceProcessInstaller.
        /// </summary>
        private ServiceProcessInstaller process;

        /// <summary>
        /// Define the object of ServiceInstaller.
        /// </summary>
        private ServiceInstaller service;            

        /// <summary>
        /// Function to define the Service Name.
        /// </summary>
        private string GetServiceName()
        {
            return "MailEngineServiceJob";
        }
        #endregion

        public MailServiceInstaller()
        {
            try
            {
                process = new ServiceProcessInstaller();
                process.Account = ServiceAccount.LocalSystem;
                service = new ServiceInstaller();
                service.ServiceName = GetServiceName();
                service.StartType = ServiceStartMode.Automatic;
                Installers.Add(process);
                Installers.Add(service);
            }
            catch
            {
                //Do Nothing
            }
        }
    }
}
