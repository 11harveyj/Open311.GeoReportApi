using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open311.GeoInquiry.Structures.Facilities
{
    public class Root
    {
        public string id { get; set; }
        public string facility_name { get; set; }
        public DateTime? expiration { get; set; }
        public string type { get; set; }
        public string brief_description { get; set; }
        public string description { get; set; }
        public Features.Root[]? features { get; set; }
        public string address { get; set; }
        public string additional_address_information { get; set; }
        public string borough { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zipcode { get; set; }
        public string displayed_hours { get; set; }
        public string lat { get; set; }
        public string @long { get; set; }
        public string eligibility_information { get; set; }
    }
}
