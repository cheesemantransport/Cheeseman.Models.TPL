using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Cheeseman.Models.TPL.Quote
{
    public class LTLQuoteRequestModel
    {
        [Description("Client specified reference information")]
        [MaxLength(40)]
        public string REFERENCE { get; set; }

        [Description("Shipper's US 5-digit Zip Code or Canadian 7-character Postal Code.")]
        [MaxLength(10)]
        [Required]
        public string START_ZONE { get; set; }

        [Description("Pick-Up Appointment required?")]
        public bool PICK_UP_APPT_REQ { get; set; } = false;

        [Description("Consignee's US 5-digit Zip Code or Canadian 7-character Postal Code.")]
        [MaxLength(10)]
        [Required]
        public string END_ZONE { get; set; }

        [Description("Delivery Appointment required?")]
        public bool DELIVERY_APPT_REQ { get; set; } = false;

        [Description("Collection of freight details.")]
        [Required]
        public IEnumerable<LTLQuoteRequestDetailModel> DETAILS { get; set; }
    }
}
