using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
#region serviceengine
using EC_Endpoint_Client.Case;
using EC_Endpoint_Client.CaseAgencySystem;
using EC_Endpoint_Client.Correspondence;
using EC_Endpoint_Client.CorrespondenceAgency;
using EC_Endpoint_Client.NotificationAgency;
using EC_Endpoint_Client.PrefillAgency;
using EC_Endpoint_Client.PrefillEUS;
using EC_Endpoint_Client.ReporteeElementList;
using EC_Endpoint_Client.SubscriptionAgency;
#endregion

namespace EC_Endpoint_Client.UserControls
{
    public partial class ServiceEngineTester : UserControl
    {
        public ServiceEngineTester()
        {
            InitializeComponent();
            rand = new Random();
        }
        Random rand;
        string biancaeid = "01014922047";
        string SOA1User = "SKDEN";
        string SOA2Pass = "Altinn1234";
        string User = "ectest1";
        string Pass = "test123";
        DateTime from = DateTime.Parse("2008-01-01");
        DateTime to = DateTime.Parse("2012-01-01");
        private void button1_Click(object sender, EventArgs e)
        {
            TestCase();
            TestCaseSOA();
            TestCorr();
            TestCorrSOA();
            TestNotifA();
            TestPrefill();
            TestPrefillA();
            TestReporteeElementList();
            TestSubscriptionAgency();
            
        }
        void TestCase()
        {
            var client = new CaseECClient("ST01");
            var x = client.ArchiveCaseEC(User, Pass, 1, false);
            var y = client.GetCaseListEC(User, Pass, 1, "123", 1, 1033, biancaeid);
            var z = client.InstantiateCollaborationEC(User, Pass, "123", 1, biancaeid, "test" + rand.Next(100000).ToString(), DateTime.Parse("2009-01-01"), DateTime.Parse("2015-01-01"));
        }
        void TestCaseSOA()
        {
            var client = new CaseAgencySystemECClient("ST01");
            var x = client.GetCaseListAgencySystemEC(SOA1User, SOA2Pass, 1, "123", 1, 1033, biancaeid);
            var y = client.InstantiateCollaborationAgencySystemEC(SOA1User, SOA2Pass, "123", 1, biancaeid, DateTime.Parse("2009-01-01"), DateTime.Parse("2015-01-01"));
            var z = client.NotifyEventAgencySystemEC(SOA1User, SOA2Pass, new StateMachineEventNotificationBE());
            client.SetNoticeAgencySystemEC(SOA1User, SOA2Pass, "123", new NoticeBE());
        }
        void TestCorrSOA()
        {
            var client = new CorrespondenceAgencyExternalECClient("ST01");
            var corr = new InsertCorrespondenceV2();
            corr.ServiceCode = "123";
            corr.ServiceEdition = "1";
            var x = client.InsertCorrespondenceEC(SOA1User, SOA2Pass, "123", "test123", corr);
        }
        void TestCorr()
        {
            var client = new CorrespondenceExternalECClient("ST01");
            var x = client.ArchiveCorrespondenceForEndUserSystemEC(User, Pass, 123);
            var y = client.GetCorrespondenceForEndUserSystemsEC(User, Pass, 123, 1033);
            client.SaveCorrespondenceConfirmationEC(User, Pass, 123);
        }
        void TestNotifA()
        {
            var client = new NotificationAgencyExternalECClient("ST01");
            var not = new StandaloneNotification();
            not.LanguageID = 1033;
            var notlist = new StandaloneNotificationBEList();
            notlist.Add(not);
            client.SendStandaloneNotificationEC(SOA1User, SOA2Pass, notlist);
        }
        void TestPrefillA()
        {
            var client = new PreFillAgencyExternalECClient("ST01");
            var x = client.SubmitAndInstantiatePrefilledFormTaskEC(SOA1User, SOA2Pass, "test" + rand.Next(100000).ToString(), new PrefillAgency.PrefillFormTask(), false, false, null, null);
            var y = client.SubmitPrefilledFormTasksEC(SOA1User, SOA2Pass, "test"+ rand.Next(100000).ToString(), new PrefillFormTaskDetails());
        }
        void TestPrefill()
        {
            var client = new PreFillEUSExternalECClient("ST01");
            var x = client.GetPrefillDataEC(User, Pass, biancaeid, "123", 1);
            var y = client.GetPrefillDataECV2(User, Pass, biancaeid, "123", 1, new PreFillRequestBEList() { "test" });
        }
        void TestReporteeElementList()
        {
            var client = new ReporteeElementListECClient("ST01");
            client.DeleteReporteeElementEC(User, Pass, "123");
            var y = client.GetCorrespondenceListForArchiveRefEC(User, Pass, biancaeid, "AR123", from, to, 1033);
            var z = client.GetCorrespondenceListForReporteeEC(User, Pass, biancaeid, from, to, 1033);
            var a = client.GetFormSetElementsEC(User, Pass, 123, 1033);
            var esBEV = new ExternalSearchBEV2();
            esBEV.FromDate = from;
            esBEV.ToDate = to;
            var b = client.GetReporteeElementListEC(User, Pass, esBEV, 1033);
        }
        void TestSubscriptionAgency()
        {
            var client = new SubscriptionAgencyExternalECClient("ST01");
            var subscr = new SubscriptionDetails();
            subscr.SystemUserCode = "SKDEN";
            subscr.Subscriptionlist = new SubscriptionList();
            subscr.Subscriptionlist.Add(new Subscription());
            var x = client.SubmitSubscriptionEC(SOA1User, SOA2Pass, "1", subscr);
        }

    }
}
