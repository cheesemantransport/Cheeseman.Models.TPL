namespace Cheeseman.Models.TPL.Quote
{
    public class QuoteModel
    {
        public string REFERENCE { get; set; }

        public string BILL_NUMBER { get; set; }

        public DateTime? EFFECTIVE_DATE { get; set; }

        public DateTime? EXPIRY_DATE { get; set; }

        public int? NUMBER_OF_USES { get; set; }

        public int? TIMES_USED { get; set; }

        public string CUSTOMER { get; set; }

        public string CALLNAME { get; set; }

        public string CALLADDR1 { get; set; }

        public string CALLADDR2 { get; set; }

        public string CALLCITY { get; set; }

        public string CALLPROV { get; set; }

        public string CALLPC { get; set; }

        public string CALLCONTACT { get; set; }

        public string CALLEMAIL { get; set; }

        public string CALLPHONE { get; set; }

        public string CALLPHONEEXT { get; set; }

        public string ORIGIN { get; set; }

        public string ORIGNAME { get; set; }

        public string ORIGADDR1 { get; set; }

        public string ORIGADDR2 { get; set; }

        public string ORIGCITY { get; set; }

        public string ORIGPROV { get; set; }

        public string ORIGPC { get; set; }

        public string DESTINATION { get; set; }

        public string DESTNAME { get; set; }

        public string DESTADDR1 { get; set; }

        public string DESTADDR2 { get; set; }

        public string DESTCITY { get; set; }

        public string DESTPROV { get; set; }

        public string DESTPC { get; set; }

        public string SERVICE_LEVEL { get; set; }

        public double? DISTANCE { get; set; }

        public double? PIECES { get; set; }

        public double? WEIGHT { get; set; }

        public double? CHARGES { get; set; }

        public double? XCHARGES { get; set; }

        public double? TOTAL_CHARGES { get; set; }

        public IEnumerable<QuoteDetailModel> DETAIL { get; set; }

        public IEnumerable<QuoteAccessorialModel> ACCESSORIAL { get; set; }
    }
}
