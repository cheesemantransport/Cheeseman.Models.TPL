using System.Text.Json.Serialization;

namespace Cheeseman.Models.TPL.Track
{
    public class TrackDocumentModel
    {
        public int DOC_ID { get; set; } = 0;

        /// <summary>
        /// 12 = DR, 13 = BOL, 14 = Load Sheet, 18 = Customs, 19 = Inspection, 20 = Freight Image, 182 = Attachment
        /// </summary>
        public int TYPE_ID { get; set; } = 0;
        public string TYPE_NAME { get; set; } = string.Empty;        
        public string FILE_NAME { get; set; } = string.Empty;
        public int SIZE { get; set; } = 0;
        public int FRAMES { get; set; } = 0;
        public int? WIDTH { get; set; } = 0;
        public int? HEIGHT { get; set; } = 0;
        /// <summary>
        /// Base64 encoded byte array
        /// </summary>
        public string BYTES { get; set; } = string.Empty;

        [JsonIgnore]
        public string FULL_PATH { get; set; } = string.Empty;
    }
}