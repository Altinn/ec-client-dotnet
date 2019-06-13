using System;
using System.Windows.Forms;
using EC_Endpoint_Client.Service_References.Case;
using EC_Endpoint_Client.Service_References.CaseAgencySystem;
using EC_Endpoint_Client.Service_References.Correspondence;
using EC_Endpoint_Client.Service_References.CorrespondenceAgency;
using EC_Endpoint_Client.Service_References.NotificationAgency;
using EC_Endpoint_Client.Service_References.PrefillAgency;
using EC_Endpoint_Client.Service_References.PrefillEUS;
using EC_Endpoint_Client.ReporteeElementList;
using EC_Endpoint_Client.Service_References.SubscriptionAgency;
using PrefillFormTask = EC_Endpoint_Client.Service_References.PrefillAgency.PrefillFormTask;

#region serviceengine

#endregion

namespace EC_Endpoint_Client.UserControls
{
    public partial class ServiceEngineTester : UserControl
    {
        public ServiceEngineTester()
        {
            InitializeComponent();
            _rand = new Random();
        }
        Random _rand;
        string _biancaeid = "01014922047";
        string _soa1User = "SKDEN";
        string _soa2Pass = "Altinn1234";
        string _user = "ectest1";
        string _pass = "test123";
        DateTime _from = DateTime.Parse("2008-01-01");
        DateTime _to = DateTime.Parse("2012-01-01");
        private void button1_Click(object sender, EventArgs e)
        {
            TestCase();
            TestCaseSoa();
            TestCorr();
            TestCorrSoa();
            TestNotifA();
            TestPrefill();
            TestPrefillA();
            TestReporteeElementList();
            TestSubscriptionAgency();
            
        }
        void TestCase()
        {
            var client = new CaseECClient("ST01");
            var x = client.ArchiveCaseEC(_user, _pass, 1, false);
            var y = client.GetCaseListEC(_user, _pass, 1, "123", 1, 1033, _biancaeid);
            var z = client.InstantiateCollaborationEC(_user, _pass, "123", 1, _biancaeid, "test" + _rand.Next(100000).ToString(), DateTime.Parse("2009-01-01"), DateTime.Parse("2015-01-01"));
        }
        void TestCaseSoa()
        {
            var client = new CaseAgencySystemECClient("ST01");
            var x = client.GetCaseListAgencySystemEC(_soa1User, _soa2Pass, 1, "123", 1, 1033, _biancaeid);
            var y = client.InstantiateCollaborationAgencySystemEC(_soa1User, _soa2Pass, "123", 1, _biancaeid, DateTime.Parse("2009-01-01"), DateTime.Parse("2015-01-01"));
            var z = client.NotifyEventAgencySystemEC(_soa1User, _soa2Pass, new StateMachineEventNotificationBE());
            client.SetNoticeAgencySystemEC(_soa1User, _soa2Pass, "123", new NoticeBE());
        }
        void TestCorrSoa()
        {
            var client = new CorrespondenceAgencyExternalECClient("ST01");
            var corr = new InsertCorrespondenceV2();
            corr.ServiceCode = "123";
            corr.ServiceEdition = "1";
            var x = client.InsertCorrespondenceEC(_soa1User, _soa2Pass, "123", "test123", corr);
        }
        void TestCorr()
        {
            var client = new CorrespondenceExternalECClient("ST01");
            var x = client.ArchiveCorrespondenceForEndUserSystemEC(_user, _pass, 123);
            var y = client.GetCorrespondenceForEndUserSystemsEC(_user, _pass, 123, 1033);
            client.SaveCorrespondenceConfirmationEC(_user, _pass, 123);
        }
        void TestNotifA()
        {
            var client = new NotificationAgencyExternalECClient("ST01");
            var not = new StandaloneNotification();
            not.LanguageID = 1033;
            var notlist = new StandaloneNotificationBEList();
            notlist.Add(not);
            client.SendStandaloneNotificationEC(_soa1User, _soa2Pass, notlist);
        }
        void TestPrefillA()
        {
            var client = new PreFillAgencyExternalECClient("ST01");
            var x = client.SubmitAndInstantiatePrefilledFormTaskEC(_soa1User, _soa2Pass, "test" + _rand.Next(100000).ToString(), new PrefillFormTask(), false, false, null, null);
            var y = client.SubmitPrefilledFormTasksEC(_soa1User, _soa2Pass, "test"+ _rand.Next(100000).ToString(), new PrefillFormTaskDetails());
        }
        void TestPrefill()
        {
            var client = new PreFillEUSExternalECClient("ST01");
            var x = client.GetPrefillDataEC(_user, _pass, _biancaeid, "123", 1);
            var y = client.GetPrefillDataECV2(_user, _pass, _biancaeid, "123", 1, new PreFillRequestBEList() { "test" });
        }
        void TestReporteeElementList()
        {
            var client = new ReporteeElementListECClient("ST01");
            client.DeleteReporteeElementEC(_user, _pass, "123");
            var y = client.GetCorrespondenceListForArchiveRefEC(_user, _pass, _biancaeid, "AR123", _from, _to, 1033);
            var z = client.GetCorrespondenceListForReporteeEC(_user, _pass, _biancaeid, _from, _to, 1033);
            var a = client.GetFormSetElementsEC(_user, _pass, 123, 1033);
            var esBev = new ExternalSearchBEV2();
            esBev.FromDate = _from;
            esBev.ToDate = _to;
            var b = client.GetReporteeElementListEC(_user, _pass, esBev, 1033);
        }
        void TestSubscriptionAgency()
        {
            var client = new SubscriptionAgencyExternalECClient("ST01");
            var subscr = new SubscriptionDetails();
            subscr.SystemUserCode = "SKDEN";
            subscr.Subscriptionlist = new SubscriptionList();
            subscr.Subscriptionlist.Add(new Subscription());
            var x = client.SubmitSubscriptionEC(_soa1User, _soa2Pass, "1", subscr);
        }

    }
}
