namespace Cheeseman.Models.TPL.Track
{
    public class TrackDocumentListModel
    {
        public int DOC_ID { get; set; } = 0;

        /// <summary>
        /// 12 = DR, 13 = BOL, 14 = Load Sheet, 18 = Customs, 19 = Inspection, 20 = Freight Image, 182 = Attachment
        /// </summary>
        public int TYPE_ID { get; set; } = 0;
        public string TYPE_NAME { get; set; } = string.Empty;
    }
}