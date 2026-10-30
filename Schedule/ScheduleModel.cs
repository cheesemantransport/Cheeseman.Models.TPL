namespace Cheeseman.Models.TPL.Schedule
{
    public class ScheduleModel
    {
        public enum BillTo { CALLER, SHIPPER, CONSIGNEE, THIRD_PARTY }

        public string QUOTE_NUMBER { get; set; } = string.Empty;
        public string SHIPMENT_NUMBER { get; set; } = string.Empty;
        public string COMMENTS { get; set; } = string.Empty;


        public BillTo BILL_TO { get; set; } = BillTo.CALLER;

        public string THIRDPARTYNAME { get; set; } = string.Empty;
        public string THIRDPARTYADDR1 { get; set; } = string.Empty;
        public string THIRDPARTYADDR2 { get; set; } = string.Empty;
        public string THIRDPARTYCITY { get; set; } = string.Empty;
        public string THIRDPARTYPROV { get; set; } = string.Empty;
        public string THIRDPARTYPC { get; set; } = string.Empty;


        public string CALLNAME { get; set; } = string.Empty;
        public string CALLADDR1 { get; set; } = string.Empty;
        public string CALLADDR2 { get; set; } = string.Empty;
        public string CALLCITY { get; set; } = string.Empty;
        public string CALLPROV { get; set; } = string.Empty;
        public string CALLPC { get; set; } = string.Empty;
        public string CALLCONTACT { get; set; } = string.Empty;
        public string CALLEMAIL { get; set; } = string.Empty;
        public string CALLPHONE { get; set; } = string.Empty;
        public string CALLPHONEEXT { get; set; } = string.Empty;


        public string ORIGNAME { get; set; } = string.Empty;
        public string ORIGADDR1 { get; set; } = string.Empty;
        public string ORIGADDR2 { get; set; } = string.Empty;
        public string ORIGCITY { get; set; } = string.Empty;
        public string ORIGPROV { get; set; } = string.Empty;
        public string ORIGPC { get; set; } = string.Empty;
        public DateTime PICK_UP_BY { get; set; } = DateTime.Today;
        public bool PICK_UP_APPT_REQ { get; set; } = false;
        public string ORIGPHONE { get; set; } = string.Empty;
        public string ORIGPHONEEXT { get; set; } = string.Empty;
        public string ORIGFAX { get; set; } = string.Empty;
        public string ORIGCELL { get; set; } = string.Empty;
        public string ORIGCONTACT { get; set; } = string.Empty;


        public string DESTNAME { get; set; } = string.Empty;
        public string DESTADDR1 { get; set; } = string.Empty;
        public string DESTADDR2 { get; set; } = string.Empty;
        public string DESTCITY { get; set; } = string.Empty;
        public string DESTPROV { get; set; } = string.Empty;
        public string DESTPC { get; set; } = string.Empty;
        public string DESTPHONE { get; set; } = string.Empty;
        public string DESTPHONEEXT { get; set; } = string.Empty;
        public string DESTFAX { get; set; } = string.Empty;
        public string DESTCELL { get; set; } = string.Empty;
        public string DESTCONTACT { get; set; } = string.Empty;
        public string DESTEMAIL { get; set; } = string.Empty;
        public bool DELIVERY_APPT_REQ { get; set; } = false;
    }
}
