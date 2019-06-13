using EC_Endpoint_Client.Classes.Shipments;
using EC_Endpoint_Client.Classes.Shipments.ServiceEngine.PrefillAgency;
using EC_Endpoint_Client.Service_References.PrefillAgency;

namespace EC_Endpoint_Client.Functionality.EndPoints.ServiceEngine.Prefill
{
    class PrefillAgencyEndPointFunction : EndPointFunctionalityBase
    {
        private string _context = "PrefillAgency";
        private PreFillAgencyExternalECClient GenerateProxy(BaseShipment shipment)
        {
            return base.GenerateProxy<PreFillAgencyExternalECClient, IPreFillAgencyExternalEC>(shipment.EndpointName,
                shipment.Certificate);
        }

        public void Test(BaseShipment shipment)
        {
            var client = GenerateProxy(shipment);
            OperationContext = _context + "Test";
            client.Test();
        }

        public ReceiptExternal SubmitAndInstantiatePrefilledFormTask(SubmitAndInstantiatePrefillFormTaskShipment shipment)
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
                shipment.DoSaveFormTask, shipment.DoInstantiateFormTask, shipment.CaseId, shipment.DueDate);
        }

        public ReceiptExternal SubmitPrefilledFormTasks(SubmitPrefillFormTaskShipment shipment)
        {
            var client = GenerateProxy(shipment);
            OperationContext = _context + "SubmitPrefilledFormTasks";
            return client.SubmitPrefilledFormTasksEC(shipment.Username, shipment.Password, shipment.ExternalBatchId, shipment.PrefillFormTask);
        }
    }
}
