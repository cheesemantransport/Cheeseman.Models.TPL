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

        [Description("Consignee's US 5-digit Zip Code or Canadian 7-character Postal Code.")]
        [MaxLength(10)]
        [Required]
        public string END_ZONE { get; set; }

        [Description("Collection of freight details.")]
        [Required]
        public IEnumerable<LTLQuoteRequestDetailModel> DETAILS { get; set; }
    }
}
