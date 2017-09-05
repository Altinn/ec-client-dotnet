using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            TestDQ();
            TestKM();
            TestRepArc();
            TestRepArcStr();
            TestSoArc();
            TestSoarcStr();


        }
        private static string SOAUser = "SKDEN";
        private static string SOAPass = "Altinn1234";
        private static string User = "ectest1";
        private static string Pass = "test123";

        void TestCommonAgency()
        {
            var client = new ArchiveCommonAgency.ArchiveCommonAgencyExternalECClient("ST01");
            //client.Test();
            //var v = client.TestAsync();
            var v = client.GetServiceOwnerArchiveReporteeElementsEC("SKDEN", "Altinn1234", new ExternalSOASearchBE(), 1044);
        }

        void TestDQ()
        {
            var client = new DownloadQueueExternalECClient("ST01");
            var x = client.GetArchivedFormTaskECDQ(SOAUser, SOAPass, "AR123", null);
        }

        void TestKM()
        {
            var client = new KeyManagementExternalECClient("ST01");
            var x = client.GetCertificatesEC(SOAUser, SOAPass, "121", 1);
        }

        void TestRepArc()
        {
            var client = new ReporteeArchiveExternalECClient("ST01");
            var x = client.GetArchivedFormTaskEC(User, Pass, 123, null);
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
