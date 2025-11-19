namespace Cheeseman.Models.TPL.Quote
{
    public class QuoteModel
    {
        public string REFERENCE { get; set; } = string.Empty;

        public string BILL_NUMBER { get; set; } = string.Empty;

        public DateTime? EFFECTIVE_DATE { get; set; } = null;

        public DateTime? EXPIRY_DATE { get; set; } = null;

        public int? NUMBER_OF_USES { get; set; } = null;

        public int? TIMES_USED { get; set; } = null;

        public string CUSTOMER { get; set; } = string.Empty;

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

        public string ORIGIN { get; set; } = string.Empty;

        public string ORIGNAME { get; set; } = string.Empty;

        public string ORIGADDR1 { get; set; } = string.Empty;

        public string ORIGADDR2 { get; set; } = string.Empty;

        public string ORIGCITY { get; set; } = string.Empty;

        public string ORIGPROV { get; set; } = string.Empty;

        public string ORIGPC { get; set; } = string.Empty;

        public string DESTINATION { get; set; } = string.Empty;

        public string DESTNAME { get; set; } = string.Empty;

        public string DESTADDR1 { get; set; } = string.Empty;

        public string DESTADDR2 { get; set; } = string.Empty;

        public string DESTCITY { get; set; } = string.Empty;

        public string DESTPROV { get; set; } = string.Empty;

        public string DESTPC { get; set; } = string.Empty;

        public string SERVICE_LEVEL { get; set; } = string.Empty;

        public double? DISTANCE { get; set; } = null;

        public double? PIECES { get; set; } = null;

        public double? WEIGHT { get; set; } = null;

        public double? CHARGES { get; set; } = null;

        public double? XCHARGES { get; set; } = null;

        public double? TOTAL_CHARGES { get; set; } = null;

        public string NOTICE { get; set; } = string.Empty;

        public IEnumerable<QuoteDetailModel> DETAIL { get; set; } = [];

        public IEnumerable<QuoteAccessorialModel> ACCESSORIAL { get; set; } = [];
    }
}
