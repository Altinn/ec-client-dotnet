using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Configuration;
using System.ServiceModel.Configuration;
using EC_Endpoint_Client.Service_References.ArchiveCommonAgency;
using EC_Endpoint_Client.Service_References.DownloadQueue;
using EC_Endpoint_Client.Service_References.KeyManagement;
using EC_Endpoint_Client.Service_References.ReporteeArchive;
using EC_Endpoint_Client.Service_References.ReporteeArchiveStreamed;
using EC_Endpoint_Client.Service_References.SOArchive;
using EC_Endpoint_Client.Service_References.SOArchiveStreamed;

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
            TestDq();
            TestKm();
            TestRepArc();
            TestRepArcStr();
            TestSoArc();
            TestSoarcStr();


        }

        private void Testsomethingelse()
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

        private static string _soaUser = "SKDEN";
        private static string _soaPass = "Altinn1234";
        private static string _user = "ectest1";
        private static string _pass = "test123";
        
        void TestCommonAgency()
        {
            ArchiveCommonAgencyExternalECClient client = new ArchiveCommonAgencyExternalECClient("ST01");
            client.Test();
            var x = client.GetServiceOwnerArchiveReporteeElementsEC("SKDEN", "Altinn1234", new ExternalSOASearchBE(), 1044);
        }

        void TestDq()
        {
            var client = new DownloadQueueExternalECClient("ST01");
            var x = client.GetArchivedFormTaskECDQ(_soaUser, _soaPass, "AR123", null);
            var y = client.GetDownloadQueueItems(_soaUser, _soaPass, "123");
            var z = client.PurgeItem(_soaUser, _soaPass, "AR123");
        }

        void TestKm()
        {
            var client = new KeyManagementExternalECClient("ST01");
            var x = client.GetCertificatesEC(_user, _pass, "121", 1);
        }

        void TestRepArc()
        {
            var client = new ReporteeArchiveExternalECClient("ST01");
            var x = client.GetArchivedFormTaskEC(_user, _pass, 123, null);
            var y = client.GetArchivedLookupEC(_user, _pass, 123, 1033);
            var z = client.GetAttachmentDataEC(_user, _pass, 123);
        }

        void TestRepArcStr()
        {
            var client = new ReporteeArchiveExternalStreamedECClient("ST01");
            var x = client.GetAttachmentDataECStreamed(_user, _pass, 123);
            
        }

        void TestSoArc()
        {
            var client = new ServiceOwnerArchiveExternalECClient("ST01");
            var x = client.GetArchivedFormTaskEC(_soaUser, _soaPass, 123, null);
            
        }

        void TestSoarcStr()
        {
            var client = new ServiceOwnerArchiveExternalStreamedECClient("ST01");
            var x = client.GetAttachmentDataStreamedEC(_soaUser, _soaPass, 123);
        }
    }
}
