using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Cheeseman.Models.TPL.Track
{
    public class TrackModel
    {
        [JsonIgnore]
        public int DETAIL_LINE_ID { get; set; }
        public string BILL_NUMBER { get; set; }
        public int MASTER_ORDER { get; set; }
        public string CURRENT_STATUS { get; set; }
        public string CURRENT_STATUS_DESC { get; set; }
        public string CURRENT_ZONE { get; set; }
        public string CURRENT_ZONE_DESC { get; set; }
        public string SERVICE_LEVEL { get; set; }
        public int PIECES { get; set; }
        public double WEIGHT { get; set; }
        public string COMMODITY { get; set; }
        public bool DANGEROUS_GOODS { get; set; }
        public double DISTANCE { get; set; }
        public string START_ZONE { get; set; }
        public string END_ZONE { get; set; }
        public string BILL_TO { get; set; }
        public string BILL_TO_CODE { get; set; }
        public string BILLNAME { get; set; }
        public string BILLADDR1 { get; set; }
        public string BILLADDR2 { get; set; }
        public string BILLCITY { get; set; }
        public string BILLPROV { get; set; }
        public string BILLPC { get; set; }
        public DateTime? BILL_DATE { get; set; }
        public string CUSTOMER { get; set; }
        public string CALLNAME { get; set; }
        public string CALLADDR1 { get; set; }
        public string CALLADDR2 { get; set; }
        public string CALLCITY { get; set; }
        public string CALLPROV { get; set; }
        public string CALLPC { get; set; }
        public string CALLPHONE { get; set; }
        public string CALLPHONEEXT { get; set; }
        public string CALLFAX { get; set; }
        public string CALLCELL { get; set; }
        public string CALLCONTACT { get; set; }
        public string CALLEMAIL { get; set; }
        public string ORIGIN { get; set; }
        public string ORIGNAME { get; set; }
        public string ORIGADDR1 { get; set; }
        public string ORIGADDR2 { get; set; }
        public string ORIGCITY { get; set; }
        public string ORIGPROV { get; set; }
        public string ORIGPC { get; set; }
        public string ORIGPHONE { get; set; }
        public string ORIGPHONEEXT { get; set; }
        public string ORIGFAX { get; set; }
        public string ORIGCELL { get; set; }
        public string ORIGCONTACT { get; set; }
        public DateTime PICK_UP_BY { get; set; }
        public DateTime PICK_UP_BY_END { get; set; }
        public bool PICK_UP_APPT_REQ { get; set; }
        public bool PICK_UP_APPT_MADE { get; set; }
        public DateTime? ACTUAL_PICKUP { get; set; }
        public string PICK_UP_DRIVER { get; set; }
        public string PICK_UP_PUNIT { get; set; }
        public string PICK_UP_TRAILER { get; set; }
        public string PICK_UP_TRAILER_TYPE { get; set; }
        public string PICK_UP_TRAILER_SCHEDULED { get; set; }
        public string PICK_UP_TRAILER_SCHEDULED_TYPE { get; set; }
        public string DESTINATION { get; set; }
        public string DESTNAME { get; set; }
        public string DESTADDR1 { get; set; }
        public string DESTADDR2 { get; set; }
        public string DESTCITY { get; set; }
        public string DESTPROV { get; set; }
        public string DESTPC { get; set; }
        public string DESTPHONE { get; set; }
        public string DESTPHONEEXT { get; set; }
        public string DESTFAX { get; set; }
        public string DESTCELL { get; set; }
        public string DESTCONTACT { get; set; }
        public string DESTEMAIL { get; set; }
        public DateTime DELIVER_BY { get; set; }
        public DateTime DELIVER_BY_END { get; set; }
        public bool DELIVERY_APPT_REQ { get; set; }
        public bool DELIVERY_APPT_MADE { get; set; }
        public DateTime? ACTUAL_DELIVERY { get; set; }
        public string DELIVERY_DRIVER { get; set; }
        public string DELIVERY_PUNIT { get; set; }
        public string DELIVERY_TRAILER { get; set; }
        public string DELIVERY_TRAILER_TYPE { get; set; }
        public string DELIVERY_TRAILER_SCHEDULED { get; set; }
        public string DELIVERY_TRAILER_SCHEDULED_TYPE { get; set; }
        public int DELIVERY_TRIP { get; set; }
        public double CHARGES { get; set; }
        public double XCHARGES { get; set; }
        public double XCHARGES_FSC { get; set; }
        public double TOTAL_CHARGES { get; set; }
        public DateTime? AGING_DATE { get; set; }
        public int AGING_DAYS { get; set; }
        public double AGING_AMOUNT { get; set; }
        public int AGING_STMT_NUM { get; set; }
        public DateTime? AGING_STMT_DATE { get; set; }
        public string CONSOLIDATED_INVOICE { get; set; }
        public bool EN_ROUTE_CONSIGNEE { get; set; }
        public DateTime? ARRSHIP { get; set; }
        public DateTime? DEPSHIP { get; set; }
        public DateTime? ARRCON { get; set; }
        public DateTime? DEPCON { get; set; }

        public IEnumerable<TrackTraceModel> TRACE { get; set; }
        public IEnumerable<TrackStatusModel> HISTORY { get; set; }
    }
}
