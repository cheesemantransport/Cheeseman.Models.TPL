using System.Text.Json.Serialization;

namespace Cheeseman.Models.TPL
{
    public class AuthModel 
    {
        [JsonIgnore]
        public string EMAIL { get; set; }
                
        public string USERNAME { get { return this.EMAIL; } }

        [JsonIgnore]
        public string PASSWORD { get; set; }

        public string CLIENT_ID { get; set; }

        public string TOKEN { get; set; }

        public string NAME_LAST { get; set; }

        public string NAME_FIRST { get; set; }

        public string NAME_MIDDLE_INITIAL { get; set; }

        public string COMPANY { get; set; }

        public string ADDRESS_1 { get; set; }

        public string ADDRESS_2 { get; set; }

        public string CITY { get; set; }

        public string PROVINCE { get; set; }

        public string POSTAL_CODE { get; set; }

        public string PHONE { get; set; }

        public string PHONE_EXT { get; set; }       

        public string MESSAGE { get; set; }
    }
}
