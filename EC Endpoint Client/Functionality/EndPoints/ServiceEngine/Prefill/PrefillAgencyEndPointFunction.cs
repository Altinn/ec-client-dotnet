using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EC_Endpoint_Client.Classes;
using EC_Endpoint_Client.Classes.Shipments.ServiceEngine.PrefillAgency;
using EC_Endpoint_Client.PrefillAgency;

namespace EC_Endpoint_Client.Functionality.EndPoints.ServiceEngine
{
    class PrefillAgencyEndPointFunction : EndPointFunctionalityBase
    {
        private string Context = "PrefillAgency";
        private PreFillAgencyExternalECClient GenerateProxy(BaseShipment shipment)
        {
            return base.GenerateProxy<PreFillAgencyExternalECClient, IPreFillAgencyExternalEC>(shipment.EndpointName,
                shipment.Certificate);
        }

        public void Test(BaseShipment shipment)
        {
            var client = GenerateProxy(shipment);
            OperationContext = Context + "Test";
            client.Test();
        }

        public ReceiptExternal SubmitAndInstantiatePrefilledFormTask(SubmitAndInstantiatePrefillFormTaskShipment shipment)
        {
            var client = GenerateProxy(shipment);
            OperationContext = Context + "SubmitAndInstantiatePrefilledFormTask";
            if (shipment.PrefillFormTask.PrefillNotifications.Count == 0)
            {
                shipment.PrefillFormTask.PrefillNotifications = null;
            }
            if (shipment.PrefillFormTask.PreFillAttachments.Count == 0)
            {
                shipment.PrefillFormTask.PreFillAttachments = null;
            }
            if (shipment.PrefillFormTask.PreFillIdentityFields.Count == 0)
            {
                shipment.PrefillFormTask.PreFillIdentityFields = null;
            }
            if (shipment.PrefillFormTask.PreFillForms.Count == 0)
            {
                shipment.PrefillFormTask.PreFillForms = null;
            }
            return client.SubmitAndInstantiatePrefilledFormTaskEC(shipment.Username, shipment.Password, shipment.ExternalBatchID, shipment.PrefillFormTask, 
                shipment.DoSaveFormTask, shipment.DoInstantiateFormTask, shipment.CaseID, shipment.DueDate);
        }

        public ReceiptExternal SubmitPrefilledFormTasks(SubmitPrefillFormTaskShipment shipment)
        {
            var client = GenerateProxy(shipment);
            OperationContext = Context + "SubmitPrefilledFormTasks";
            return client.SubmitPrefilledFormTasksEC(shipment.Username, shipment.Password, shipment.ExternalBatchID, shipment.PrefillFormTask);
        }
    }
}
