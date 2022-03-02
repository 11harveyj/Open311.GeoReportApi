using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open311.GeoInquiry.Structures.Service
{
    public class Root
    {
        public string id { get; set; }
        public string service_name { get; set; }
        public DateTime? expiration { get; set; }
        public Categories.Category[] categories { get; set; }
        public string url { get; set; }
        public string brief_description { get; set; }
        public string description { get; set; }
        public string description_html { get; set; }
        public WebActions.Root[] web_actions { get; set; }
    }
}
