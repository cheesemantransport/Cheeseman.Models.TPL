using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Cheeseman.Models.TPL.Transit
{
    public class TransitTimeRequestModel
    {
        [Description("Service Level (LTL or TRUCKLOAD).")]
        [MaxLength(10)]
        [Required]
        [AllowedValues("LTL", "TRUCKLOAD", ErrorMessage = "SERVICE_LEVEL must be \"LTL\" or \"TRUCKLOAD\"")]
        public string SERVICE_LEVEL { get; set; } = "LTL";

        [Description("Shipper's US 5-digit Zip Code or Canadian 7-character Postal Code.")]
        [MaxLength(10)]
        [Required]
        public string START_ZONE { get; set; }

        [Description("Consignee's US 5-digit Zip Code or Canadian 7-character Postal Code.")]
        [MaxLength(10)]
        [Required]
        public string END_ZONE { get; set; }

        [Description("Date of the pick-up.")]
        [Required]
        public DateTime PICK_UP_DATE { get; set; }
    }
}
