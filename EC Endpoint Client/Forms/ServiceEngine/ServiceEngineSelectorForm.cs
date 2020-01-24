using System;
using EC_Endpoint_Client.Forms.ServiceEngine.ContextHandler;
using EC_Endpoint_Client.Forms.ServiceEngine.Correspondence;
using EC_Endpoint_Client.Forms.ServiceEngine.LookUp;
using System.Security.Cryptography.X509Certificates;

namespace EC_Endpoint_Client.Forms.ServiceEngine
{
    public partial class ServiceEngineSelectorForm : BaseForms.SelectorBaseForm
    {
        public ServiceEngineSelectorForm(string thumb, X509Certificate2 cert, bool useEC2Interface) : base(thumb, cert, useEC2Interface)
        {
            InitializeComponent();
        }

        private void btn_Case_Click(object sender, EventArgs e)
        {
            //Case
            if (UseEC2Interface)
            {
                Case.CaseFormEC2 cf = new Case.CaseFormEC2();
                cf.Text = "CaseForm (EC2)";
                SetClientValues(cf, "CaseEC2.ICaseEC2");
                ShowMethod1(cf);
            }
            else
            {
                Case.CaseForm cf = new Case.CaseForm();
                cf.Text = "CaseForm (EC)";
                SetClientValues(cf, "Case.ICaseEC");
                ShowMethod1(cf);
            }
        }

        private void btn_CaseAgency_Click(object sender, EventArgs e)
        {
            //CaseAgency
            if (UseEC2Interface)
            {
                Case.CaseAgencyFormEC2 caf = new Case.CaseAgencyFormEC2();
                caf.Text = "CaseAgencyForm (EC2)";
                SetClientValues(caf, "CaseAgencySystemEC2.ICaseAgencySystemEC2");
                ShowMethod1(caf);
            }
            else
            {
                Case.CaseAgencyForm caf = new Case.CaseAgencyForm();
                caf.Text = "CaseAgencyForm (EC)";
                SetClientValues(caf, "CaseAgencySystem.ICaseAgencySystemEC");
                ShowMethod1(caf);
            }
        }

        private void btn_Correspondence_Click(object sender, EventArgs e)
        {
            //Correspondence
            if (UseEC2Interface)
            {
                CorrespondenceFormEC2 cf = new CorrespondenceFormEC2();
                cf.Text = "CorrespondenceForm (EC2)";
                SetClientValues(cf, "CorrespondenceEC2.ICorrespondenceExternalEC2");
                ShowMethod1(cf);
            }
            else
            {
                CorrespondenceForm cf = new CorrespondenceForm();
                cf.Text = "CorrespondenceForm (EC)";
                SetClientValues(cf, "CorrespondenceEC2.ICorrespondenceExternalEC2");
                ShowMethod1(cf);
            }
            
        }

        private void btn_CorrespondenceAgency_Click(object sender, EventArgs e)
        {
            //CorrespondenceAgency
            if (UseEC2Interface)
            {
                CorrespondenceAgencyFormEC2 caf = new CorrespondenceAgencyFormEC2();
                caf.Text = "CorrespondenceAgencyForm (EC2)";
                SetClientValues(caf, "CorrespondenceAgencyEC2.ICorrespondenceAgencyExternalEC2");
                ShowMethod1(caf);
            }
            else
            {
                CorrespondenceAgencyForm caf = new CorrespondenceAgencyForm();
                caf.Text = "CorrespondenceAgencyForm (EC)";
                SetClientValues(caf, "CorrespondenceAgency.ICorrespondenceAgencyExternalEC");
                ShowMethod1(caf);
            }
            
        }

        private void btn_CorrespondenceAgencyNosystem_Click(object sender, EventArgs e)
        {
            if (UseEC2Interface)
            {
                CorrespondenceAgencyNoSystemFormEC2 cansf = new CorrespondenceAgencyNoSystemFormEC2();
                cansf.Text = "CorrespondenceAgencyNoSystemForm (EC2)";
                SetClientValues(cansf, "CorrespondenceAgencyNoSystemEC2.ICorrespondenceAgencyExternalAEC2");
                ShowMethod1(cansf);
            }
            else
            {
                CorrespondenceAgencyNoSystemForm cansf = new CorrespondenceAgencyNoSystemForm();
                cansf.Text = this.UseEC2Interface ? "CorrespondenceAgencyNoSystemForm (EC2)" : "CorrespondenceAgencyNoSystemForm (EC)";
                SetClientValues(cansf, this.UseEC2Interface ? "CorrespondenceAgencyNoSystem.ICorrespondenceAgencyExternalAEC2" : "CorrespondenceAgencyNoSystem.ICorrespondenceAgencyExternalAEC");
                ShowMethod1(cansf);
            }
            
        }

        private void btn_PrefillEUS_Click(object sender, EventArgs e)
        {
            //PrefillEUS
            if (UseEC2Interface)
            {
                Prefill.PrefillFormEC2 pf = new Prefill.PrefillFormEC2();
                pf.Text = "PrefillForm (EC2)";
                SetClientValues(pf, "PrefillEUSEC2.IPreFillEUSExternalEC2");
                ShowMethod1(pf);
            }
            else
            {
                Prefill.PrefillForm pf = new Prefill.PrefillForm();
                pf.Text = "PrefillForm (EC2)";
                SetClientValues(pf, "PrefillEUS.IPreFillEUSExternalEC");
                ShowMethod1(pf);
            }
            
        }

        private void btn_PrefillAgency_Click(object sender, EventArgs e)
        {
            //PrefillAgency
            if (UseEC2Interface)
            {
                Prefill.PrefillAgencyFormEC2 paf = new Prefill.PrefillAgencyFormEC2();
                paf.Text = "PrefillAgencyForm (EC2)";
                SetClientValues(paf, "PrefillAgencyEC2.IPreFillAgencyExternalEC2");
                ShowMethod1(paf);
            }
            else
            {
                Prefill.PrefillAgencyForm paf = new Prefill.PrefillAgencyForm();
                paf.Text = "PrefillAgencyForm (EC)";
                SetClientValues(paf, "PrefillAgency.IPreFillAgencyExternalEC");
                ShowMethod1(paf);
            }
            
        }

        private void btn_NotificationAgency_Click(object sender, EventArgs e)
        {
            if (UseEC2Interface)
            {
                NotificationAgencyFormEC2 naf = new NotificationAgencyFormEC2();
                naf.Text = "NotificationAgencyForm (EC2)";
                SetClientValues(naf, "NotificationAgencyEC2.INotificationAgencyExternalEC2");
                ShowMethod1(naf);
            }
            else
            {
                NotificationAgencyForm naf = new NotificationAgencyForm();
                naf.Text = "NotificationAgencyForm (EC)";
                SetClientValues(naf, "NotificationAgency.INotificationAgencyExternalEC");
                ShowMethod1(naf);
            }
            
        }

        private void btn_ReporteeElementList_Click(object sender, EventArgs e)
        {
            if (UseEC2Interface)
            {
                ReporteeElementListFormEC2 relf = new ReporteeElementListFormEC2();
                relf.Text = "ReporteeElementListForm (EC2)";
                SetClientValues(relf, "ReporteeElementListEC2.IReporteeElementListEC2");
                ShowMethod1(relf);
            }
            else
            {
                ReporteeElementListForm relf = new ReporteeElementListForm();
                relf.Text = "ReporteeElementListForm (EC)";
                SetClientValues(relf, "ReporteeElementList.IReporteeElementListEC");
                ShowMethod1(relf);
            }
        }

        private void btn_SubscriptionAgency_Click(object sender, EventArgs e)
        {
            if (UseEC2Interface)
            {
                SubscriptionAgencyFormEC2 saf = new SubscriptionAgencyFormEC2();
                saf.Text = "SubscriptionAgencyForm (EC2)";
                SetClientValues(saf, "SubscriptionAgencyEC2.ISubscriptionAgencyExternalEC2");
                ShowMethod1(saf);
            }
            else
            {
                SubscriptionAgencyForm saf = new SubscriptionAgencyForm();
                saf.Text = "SubscriptionAgencyForm (EC)";
                SetClientValues(saf, "SubscriptionAgency.ISubscriptionAgencyExternalEC");
                ShowMethod1(saf);
            }
            
        }

        private void btn_ContextHandlerAgency_Click(object sender, EventArgs e)
        {
            if (UseEC2Interface)
            {
                ContextHandlerAgencyFormEC2 chaf = new ContextHandlerAgencyFormEC2();
                chaf.Text = "ContextHandlerAgencyForm (EC2)";
                SetClientValues(chaf, "ContextHandlerEC2.IContextHandlerEC2");
                ShowMethod1(chaf);
            }
            else
            {
                ContextHandlerAgencyForm chaf = new ContextHandlerAgencyForm();
                chaf.Text = "ContextHandlerAgencyForm (EC)";
                SetClientValues(chaf, "ContextHandler.IContextHandlerEC");
                ShowMethod1(chaf);
            }
        }

        private void btn_BrokerService_Click(object sender, EventArgs e)
        {
            //BrokerService
            if (UseEC2Interface)
            {
                BrokerService.BrokerServiceFormEC2 bsf = new BrokerService.BrokerServiceFormEC2();
                bsf.Text = "BrokerServiceForm (EC2)";
                SetClientValues(bsf, "BrokerServiceEC2.IBrokerServiceExternalEC");
                ShowMethod1(bsf);
            }
            else
            {
                BrokerService.BrokerServiceForm bsf = new BrokerService.BrokerServiceForm();
                bsf.Text = "BrokerServiceForm (EC)";
                SetClientValues(bsf, "BrokerService.IBrokerServiceExternalEC");
                ShowMethod1(bsf);
            }
            
        }

        private void btn_LookUp_Click(object sender, EventArgs e)
        {
            //LookUp
            if (UseEC2Interface)
            {
                LookUpFormEC2 luf = new LookUpFormEC2();
                luf.Text = "LookUpForm (EC2)";
                SetClientValues(luf, "LookUpEC2.ILookUpExternalEC2");
                ShowMethod1(luf);
            }
            else
            {
                LookUpForm luf = new LookUpForm();
                luf.Text = "LookUpForm (EC)";
                SetClientValues(luf, "LookUp.ILookUpExternalEC");
                ShowMethod1(luf);
            }
        }
    }
}
