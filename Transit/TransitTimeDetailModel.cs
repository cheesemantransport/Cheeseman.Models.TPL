using System.ComponentModel;

namespace Cheeseman.Models.TPL.Transit
{
    public class TransitTimeDetailModel
    {
        [Description("Service level day.")]
        public DateTime SLM_DAY { get; set; }

        [Description("Day represents a deviation from the standard service level transit days.")]
        public bool DELAY { get; set; }

        [Description("Reason for the delay day.")]
        public string DELAY_REASON { get; set; } 
    }
}
