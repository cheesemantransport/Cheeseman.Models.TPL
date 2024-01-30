namespace Cheeseman.Models.TPL.Quote
{
    public class LTLQuoteRequestDetailModel
    {
        public string COMMODITY { get; set; }
        public string DESCRIPTION { get; set; }
        public int PIECES { get; set; }
        public double WEIGHT { get; set; }
        public bool DANGEROUS_GOODS { get; set; }
        public bool TEMP_CONTROLLED { get; set; }
        public bool STACKABLE { get; set; }
    }
}
