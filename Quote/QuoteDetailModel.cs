namespace Cheeseman.Models.TPL.Quote
{
    public class QuoteDetailModel
    {
        public string COMMODITY { get; set; } = string.Empty;
        public string DESCRIPTION { get; set; } = string.Empty;
        public int PIECES { get; set; } = 0;
        public string PIECES_UNITS { get; set; } = string.Empty;
        public double WEIGHT { get; set; } = 0.0;
        public string WEIGHT_UNITS { get; set; } = string.Empty;
        public double? AREA { get; set; } = null;
        public string DANGEROUS_GOODS { get; set; } = string.Empty;
        public string TEMP_CONTROLLED { get; set; } = string.Empty;
        public double? RATE { get; set; } = null;
        public double? SUB_COST { get; set; } = null;
        public double? DISCOUNT_RATE { get; set; } = null;
        public double? DISCOUNT { get; set; } = null;
        public double? COST { get; set; } = null;
        public string RATE_SHEET { get; set; } = string.Empty;
    }
}
