using System;

namespace EC_Endpoint_Client.Classes
{
    public class ActionSet : IComparable<ActionSet>
    {
        public string ActionSetName { get; set; }
        public Action ShowShipment { get; set; }
        public Action SaveShipment { get; set; }
        public Action LoadShipment { get; set; }
        public Action InvokeService { get; set; }
        public Action ShowResult { get; set; }
        public Action SaveResult { get; set; }
        public int CompareTo(ActionSet other)
        {
            return string.Compare(ActionSetName, other.ActionSetName, StringComparison.Ordinal);
        }
    }

    public class CustomActionContainer
    {
        public Action CustomAction { get; set; }
        public string ButtonText { get; set; }
        public CustomActionType Type { get; set; }
    }

    public enum CustomActionType
    {
        Request,
        Result
    }
}
