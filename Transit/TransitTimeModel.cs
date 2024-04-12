using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace Cheeseman.Models.TPL.Transit
{
    public class TransitTimeModel
    {
        [Description("Service Level (LTL or TRUCKLOAD).")]
         public string SERVICE_LEVEL { get; set; } = "LTL";

        [Description("Shipper's US 5-digit Zip Code or Canadian 7-character Postal Code.")]
        public string START_ZONE { get; set; }

        [Description("Consignee's US 5-digit Zip Code or Canadian 7-character Postal Code.")]
        public string END_ZONE { get; set; }

        [Description("Date of the pick-up.")]
        public DateTime PICK_UP_DATE { get; set; }

        [Description("Standard service level transit days.")]
        public int STANDARD_TRANSIT_DAYS => DETAILS.Count() == 0 ? -1 : DETAILS.Where(x => !x.DELAY).Count();

        [Description("Estimated delivery date including standard transit time days and delays..")]
        public DateTime? ESTIMATED_DELIVERY_DATE => DETAILS.Count() == 0 ? null : DETAILS.Max(x => x.SLM_DAY);

        [Description("Number non-service days resulting in deviation from standard service level transit days.")]
        public int DELAYS => DETAILS.Count() == 0 ? -1 : DETAILS.Where(x => x.DELAY).Count();

        [Description("Details about each day included in the transit time.")]
        public IEnumerable<TransitTimeDetailModel> DETAILS { get; set; } = new List<TransitTimeDetailModel>();
    }
}
