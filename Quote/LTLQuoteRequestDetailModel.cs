using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Cheeseman.Models.TPL.Quote
{
    public class LTLQuoteRequestDetailModel
    {
        
        [Description("Commodity (Freight Class) - must be 50, 55, 60, 65, 70, 77.5, 85, 92.5, 100, 110, 125, 150, 175, 200, 250, 300, 400, or 500")]
        [AllowedValues("50", "55", "60", "65", "70", "77.5", "85", "92.5", "100", "110", "125", "150", "175", "200", "250", "300", "400", "500")]
        [Required]        
        public string COMMODITY { get; set; }

        [Description("Description of the freight being quoted.")]
        [MaxLength(80)]
        [Required]        
        public string DESCRIPTION { get; set; }

        [DefaultValue(1)]
        [Description("Number of handling units")]
        [Range(1,9999)]
        [Required]       
        public int PIECES { get; set; } = 1;


        [DefaultValue(1)]
        [Description("Weight in pounds")]
        [Range(1,45000)]
        [Required]
        public double WEIGHT { get; set; } = 1;

        [DefaultValue(false)]
        [Description("Does the freight contain hazardous material?")]
        [Required]        
        public bool DANGEROUS_GOODS { get; set; } = false;

        [DefaultValue(false)]
        [Description("Does the freight require freeze protection?")]
        [Required]        
        public bool TEMP_CONTROLLED { get; set; } = false;

        [DefaultValue(false)]
        [Description("Is the freight is stackable?")]
        [Required]    
        public bool STACKABLE { get; set; } = false;
    }
}
