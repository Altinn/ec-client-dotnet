using EC_Endpoint_Client.Classes.Shipments;
using EC_Endpoint_Client.Classes.Shipments.ServiceEngine.PrefillAgency;
using EC_Endpoint_Client.PrefillAgencyEC2;

namespace EC_Endpoint_Client.Functionality.EndPoints.ServiceEngine.Prefill
{
    class PrefillAgencyEndPointFunctionEC2 : EndPointFunctionalityBase
    {
        private string _context = "PrefillAgency";
        private PreFillAgencyExternalEC2Client GenerateProxy(BaseShipment shipment)
        {
            return base.GenerateProxy<PreFillAgencyExternalEC2Client, IPreFillAgencyExternalEC2>(shipment.EndpointName,
                shipment.Certificate);
        }

        public void Test(BaseShipment shipment)
        {
            var client = GenerateProxy(shipment);
            OperationContext = _context + "Test";
            client.Test();
        }

        public ReceiptExternal SubmitAndInstantiatePrefilledFormTask(SubmitAndInstantiatePrefillFormTaskShipmentEC2 shipment)
        {
            var client = GenerateProxy(shipment);
            OperationContext = _context + "SubmitAndInstantiatePrefilledFormTask";
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
            return client.SubmitAndInstantiatePrefilledFormTaskEC(shipment.Username, shipment.Password, shipment.ExternalBatchId, shipment.PrefillFormTask, 
                shipment.DoSaveFormTask, shipment.DoInstantiateFormTask, shipment.CaseId, shipment.DueDate, null);
        }

        public ReceiptExternal SubmitPrefilledFormTasks(SubmitPrefillFormTaskShipmentEC2 shipment)
        {
            var client = GenerateProxy(shipment);
            OperationContext = _context + "SubmitPrefilledFormTasks";
            return client.SubmitPrefilledFormTasksEC(shipment.Username, shipment.Password, shipment.ExternalBatchId, shipment.PrefillFormTask);
        }
    }
}
