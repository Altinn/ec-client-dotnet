using System;
using System.Windows.Forms;
using EC_Endpoint_Client.ArchiveCommonAgency;
using EC_Endpoint_Client.DownloadQueue;
using EC_Endpoint_Client.KeyManagement;
using EC_Endpoint_Client.ReporteeArchive;
using EC_Endpoint_Client.ReporteeArchiveStreamed;
using EC_Endpoint_Client.SOArchive;
using EC_Endpoint_Client.SOArchiveStreamed;

namespace EC_Endpoint_Client.Forms
{
    public partial class ArchiveMultiTester : Form
    {
        public ArchiveMultiTester()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TestCommonAgency();
            TestDq();
            TestKm();
            TestRepArc();
            TestRepArcStr();
            TestSoArc();
            TestSoarcStr();


        }
        private static string _soaUser = "SKDEN";
        private static string _soaPass = "Altinn1234";
        private static string _user = "ectest1";
        private static string _pass = "test123";

        void TestCommonAgency()
        {
            var client = new ArchiveCommonAgencyExternalECClient("ST01");
            //client.Test();
            //var v = client.TestAsync();
            var v = client.GetServiceOwnerArchiveReporteeElementsEC("SKDEN", "Altinn1234", new ExternalSOASearchBE(), 1044);
        }

        void TestDq()
        {
            var client = new DownloadQueueExternalECClient("ST01");
            var x = client.GetArchivedFormTaskECDQ(_soaUser, _soaPass, "AR123", null);
        }

        void TestKm()
        {
            var client = new KeyManagementExternalECClient("ST01");
            var x = client.GetCertificatesEC(_soaUser, _soaPass, "121", 1);
        }

        void TestRepArc()
        {
            var client = new ReporteeArchiveExternalECClient("ST01");
            var x = client.GetArchivedFormTaskEC(_user, _pass, 123, null);
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
