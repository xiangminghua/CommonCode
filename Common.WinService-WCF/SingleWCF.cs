using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceModel;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace Common.WinService_WCF
{
    partial class SingleWCF : ServiceBase
    {
        public ServiceHost serviceHost = null;
        public SingleWCF()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            //启动服务的时候，有安装VS 可以启动调试代码
            //Debugger.Launch();
            serviceHost = new ServiceHost(typeof(WCFService));
            serviceHost.Open();
        }

        protected override void OnStop()
        {
            serviceHost.Close();
        }
    }
}
