using System.ServiceProcess;
using System.ServiceModel;
using WcfServices.Services;

namespace WcfServices.HostingWindowsService
{
    public partial class CalculatorHost : ServiceBase
    {
        private ServiceHost _host;

        public ServiceHost Host
        {
            get { return _host; }
            set { _host = value; }
        }


        public CalculatorHost()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            Host = new ServiceHost(typeof(CalculatorService));
            Host.Open();
        }

        protected override void OnStop()
        {
            if (Host != null)
            {
                Host.Close();
                Host = null;
            }

        }
    }
}
