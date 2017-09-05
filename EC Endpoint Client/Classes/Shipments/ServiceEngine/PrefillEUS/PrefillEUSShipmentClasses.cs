﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EC_Endpoint_Client.PrefillEUS;

namespace EC_Endpoint_Client.Classes.Shipments.ServiceEngine.PrefillEUS
{
    public class GetPrefillDataShipmentBase : BaseShipment
    {
        public string ReporteeNumber { get; set; }
        public string ExternalServiceCode { get; set; }
        public int ExternalServiceEditionCode { get; set; }
    }

    public class GetPrefillDataV2Shipment : GetPrefillDataShipmentBase
    {
        public PreFillRequestBEList PrefillBEList { get; set; }
    }

    public class GetPrefillDataV2ShipmentExt : GetPrefillDataShipmentBase
    {
        public string[] PrefillBEList { get; set; }
    }
}