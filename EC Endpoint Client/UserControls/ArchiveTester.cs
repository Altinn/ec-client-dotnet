using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EC_Endpoint_Client.ArchiveCommonAgency;
using EC_Endpoint_Client.DownloadQueue;
using EC_Endpoint_Client.KeyManagement;
using EC_Endpoint_Client.ReporteeArchive;
using EC_Endpoint_Client.ReporteeArchiveStreamed;
using EC_Endpoint_Client.SOArchive;
using EC_Endpoint_Client.SOArchiveStreamed;
using System.Xml;
using System.Configuration;
using System.ServiceModel.Configuration;

namespace EC_Endpoint_Client.UserControls
{
    public partial class ArchiveTester : UserControl
    {
        public ArchiveTester()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //testsomethingelse();
            
            TestCommonAgency();
            TestDQ();
            TestKM();
            TestRepArc();
            TestRepArcStr();
            TestSoArc();
            TestSoarcStr();


        }

        private void testsomethingelse()
        {
            var list = GetEndpointContractsByArea("ArchiveExternal");
            var list2 = GetEndPointByContract(list[0]);
        }

        private List<string> GetEndpointContractsByArea(string endPointArea)
        {
            var clientSection = (ClientSection)ConfigurationManager.GetSection("system.serviceModel/client");
            var list = new List<string>();
            foreach (ChannelEndpointElement ep in clientSection.Endpoints)
            {
                if (ep.Address.ToString().Contains(endPointArea))
                {
                    if (!list.Contains(ep.Contract))
                        list.Add(ep.Contract);
                }
            }
            return list;
        }

        private List<string> GetEndPointByContract(string contract)
        {
            var clientSection = (ClientSection)ConfigurationManager.GetSection("system.serviceModel/client");
            var list = new List<string>();
            foreach (ChannelEndpointElement ep in clientSection.Endpoints)
            {
                if (ep.Contract == contract)
                    list.Add(ep.Name);
            }
            return list;
        }

        private static string SOAUser = "SKDEN";
        private static string SOAPass = "Altinn1234";
        private static string User = "ectest1";
        private static string Pass = "test123";
        
        void TestCommonAgency()
        {
            ArchiveCommonAgency.ArchiveCommonAgencyExternalECClient client = new ArchiveCommonAgency.ArchiveCommonAgencyExternalECClient("ST01");
            client.Test();
            var x = client.GetServiceOwnerArchiveReporteeElementsEC("SKDEN", "Altinn1234", new ArchiveCommonAgency.ExternalSOASearchBE(), 1044);
        }

        void TestDQ()
        {
            var client = new DownloadQueueExternalECClient("ST01");
            var x = client.GetArchivedFormTaskECDQ(SOAUser, SOAPass, "AR123", null);
            var y = client.GetDownloadQueueItems(SOAUser, SOAPass, "123");
            var z = client.PurgeItem(SOAUser, SOAPass, "AR123");
        }

        void TestKM()
        {
            var client = new KeyManagementExternalECClient("ST01");
            var x = client.GetCertificatesEC(User, Pass, "121", 1);
        }

        void TestRepArc()
        {
            var client = new ReporteeArchiveExternalECClient("ST01");
            var x = client.GetArchivedFormTaskEC(User, Pass, 123, null);
            var y = client.GetArchivedLookupEC(User, Pass, 123, 1033);
            var z = client.GetAttachmentDataEC(User, Pass, 123);
        }

        void TestRepArcStr()
        {
            var client = new ReporteeArchiveExternalStreamedECClient("ST01");
            var x = client.GetAttachmentDataECStreamed(User, Pass, 123);
            
        }

        void TestSoArc()
        {
            var client = new ServiceOwnerArchiveExternalECClient("ST01");
            var x = client.GetArchivedFormTaskEC(SOAUser, SOAPass, 123, null);
            
        }

        void TestSoarcStr()
        {
            var client = new ServiceOwnerArchiveExternalStreamedECClient("ST01");
            var x = client.GetAttachmentDataStreamedEC(SOAUser, SOAPass, 123);
        }
    }
}
