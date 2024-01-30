using System.ComponentModel.DataAnnotations;

namespace Cheeseman.Models.TPL.Quote
{
    public class LTLQuoteRequestModel
    {
        /// <summary>
        /// Client specified reference information.
        /// </summary>
        [MaxLength(40)]
        public string REFERENCE { get; set; }

        /// <summary>
        /// Shipper's US 5-digit Zip Code or Canadian 7-character Postal Code.
        /// </summary>
        [MaxLength(10)]
        public string START_ZONE { get; set; }

        /// <summary>
        /// Consignee's US 5-digit Zip Code or Canadian 7-character Postal Code.
        /// </summary>
        [MaxLength(10)]
        public string END_ZONE { get; set; }

        /// <summary>
        /// Collection of freight details.
        /// </summary>
        public IEnumerable<LTLQuoteRequestDetailModel> DETAILS { get; set; }
    }
}
