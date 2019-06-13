using System;
using EC_Endpoint_Client.Forms.ServiceEngine.ContextHandler;
using EC_Endpoint_Client.Forms.ServiceEngine.Correspondence;
using EC_Endpoint_Client.Forms.ServiceEngine.LookUp;

namespace EC_Endpoint_Client.Forms.ServiceEngine
{
    public partial class ServiceEngineSelectorForm : BaseForms.SelectorBaseForm
    {
        public ServiceEngineSelectorForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Case
            Case.CaseForm cf = new Case.CaseForm();
            SetClientValues(cf, "Case.ICaseEC");
            ShowMethod1(cf);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //CaseAgency
            Case.CaseAgencyForm caf = new Case.CaseAgencyForm();
            SetClientValues(caf, "CaseAgencySystem.ICaseAgencySystemEC");
            ShowMethod1(caf);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Correspondence
            CorrespondenceForm cf = new CorrespondenceForm();
            SetClientValues(cf, "Correspondence.ICorrespondenceExternalEC");
            ShowMethod1(cf);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //CorrespondenceAgency
            CorrespondenceAgencyForm caf = new CorrespondenceAgencyForm();
            SetClientValues(caf, "CorrespondenceAgency.ICorrespondenceAgencyExternalEC");
            ShowMethod1(caf);
        }

        private void CorrespondenceAgencyNosystem_Click(object sender, EventArgs e)
        {
            CorrespondenceAgencyNoSystemForm cansf = new CorrespondenceAgencyNoSystemForm();
            SetClientValues(cansf, "CorrespondenceAgencyNoSystem.ICorrespondenceAgencyExternalAEC");
            ShowMethod1(cansf);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //PrefillEUS
            Prefill.PrefillForm pf = new Prefill.PrefillForm();
            SetClientValues(pf, "PrefillEUS.IPreFillEUSExternalEC");
            ShowMethod1(pf);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //PrefillAgency
            Prefill.PrefillAgencyForm paf = new Prefill.PrefillAgencyForm();
            SetClientValues(paf, "PrefillAgency.IPreFillAgencyExternalEC");
            ShowMethod1(paf);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            NotificationAgencyForm naf = new NotificationAgencyForm();
            SetClientValues(naf, "NotificationAgency.INotificationAgencyExternalEC");
            ShowMethod1(naf);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ReporteeElementListForm relf = new ReporteeElementListForm();
            SetClientValues(relf, "ReporteeElementList.IReporteeElementListEC");
            ShowMethod1(relf);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            SubscriptionAgencyForm saf = new SubscriptionAgencyForm();
            SetClientValues(saf, "SubscriptionAgency.ISubscriptionAgencyExternalEC");
            ShowMethod1(saf);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ContextHandlerAgencyForm chaf = new ContextHandlerAgencyForm();
            SetClientValues(chaf, "ContextHandler.IContextHandlerEC");
            ShowMethod1(chaf);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //BrokerService
            BrokerService.BrokerServiceForm bsf = new BrokerService.BrokerServiceForm();
            SetClientValues(bsf, "BrokerService.IBrokerServiceExternalEC");
            ShowMethod1(bsf);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //LookUp
            LookUpForm luf = new LookUpForm();
            SetClientValues(luf, "LookUp.ILookUpExternalEC");
            ShowMethod1(luf);
        }
    }
}
