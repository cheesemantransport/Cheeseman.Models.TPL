namespace Cheeseman.Models.TPL.Quote
{
    public class QuoteDetailModel
    {
        public string COMMODITY { get; set; }
        public string DESCRIPTION { get; set; }
        public double PIECES { get; set; }
        public string PIECES_UNITS { get; set; }
        public double WEIGHT { get; set; }
        public string WEIGHT_UNITS { get; set; }
        public double? AREA { get; set; }
        public string DANGEROUS_GOODS { get; set; }
        public string TEMP_CONTROLLED { get; set; }
        public double? RATE { get; set; }
        public double? SUB_COST { get; set; }
        public double? DISCOUNT_RATE { get; set; }
        public double? DISCOUNT { get; set; }
        public double? COST { get; set; }
        public string RATE_SHEET { get; set; }
    }
}
