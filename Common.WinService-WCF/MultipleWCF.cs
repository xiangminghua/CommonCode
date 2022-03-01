using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.ServiceModel;
using System.ServiceModel.Configuration;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace Common.WinService_WCF
{
    public partial class MultipleWCF : ServiceBase
    {
        //list列表 ，用于存储打开的服务列表
        List<ServiceHost> _host = new List<ServiceHost>();
        public MultipleWCF()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            Configuration conf = ConfigurationManager.OpenExeConfiguration(Assembly.GetEntryAssembly().Location);
            ServiceModelSectionGroup svcmod = (ServiceModelSectionGroup)conf.GetSectionGroup("system.serviceModel");
            foreach (ServiceElement el in svcmod.Services.Services)
            {
                Type svcType = Type.GetType(el.Name);
                if (svcType == null)
                { continue; }
                //    throw new Exception("Invalid Service Type " + el.Name + " in configuration file.");
                ServiceHost aServiceHost = new ServiceHost(svcType);
                //WCF认证
                //var binding = new BasicHttpBinding(BasicHttpSecurityMode.Transport);
                //binding.Security.Transport.ClientCredentialType = HttpClientCredentialType.Certificate;
                ////WCF地址： el.Endpoints[0].Address 
                //aServiceHost.AddServiceEndpoint(typeof(IItemService), binding, el.Endpoints[0].Address);

                //方式2：netTcpBinding
                //var bingding = new NetTcpBinding(SecurityMode.Transport);
                //bingding.Security.Transport.ProtectionLevel = ProtectionLevel.EncryptAndSign;
                //bingding.Security.Transport.ClientCredentialType = TcpClientCredentialType.Certificate;
                //aServiceHost.AddServiceEndpoint(typeof(IItemService), bingding, "");

                //设置证书X509
                //aServiceHost.Credentials.ServiceCertificate.SetCertificate(StoreLocation.LocalMachine, StoreName.My, X509FindType.FindBySubjectName, "TestServer");
                //aServiceHost.Credentials.ClientCertificate.Authentication.CertificateValidationMode = X509CertificateValidationMode.None;

                aServiceHost.Open();
                _host.Add(aServiceHost);
            }

        }

        protected override void OnStop()
        {
            foreach (ServiceHost host in _host)
            {
                host.Close();
            }
            //清空列表里面的服务
            _host.Clear();
        }
    }
}
