using System;

namespace Cheeseman.Models.TPL.Track
{
    public class TrackStatusModel
    {
        public DateTime CHANGED { get; set; }

        public string STATUS_CODE { get; set; }

        public string STATUS_DESCRIPTION { get; set; }

        public string ZONE_ID { get; set; }

        public string ZONE_DESCRIPTION { get; set; }

    }
}
