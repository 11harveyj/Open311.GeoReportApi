using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open311.GeoReport.Structures.ServiceRequest
{
    public class Root
    {
        public string service_request_id { get; set; }
        public enum statusEnum {
            OPEN = 0,
            CLOSED = 1
        }
        public string status { get; set; }
        public string status_notes { get; set; }
        public string service_name { get; set; }
        public string service_code { get; set; }
        public string description { get; set; }
        public string agency_responsible { get; set; }
        public string service_notice { get; set; }
        public DateTime? requested_datetime { get; set; }
        public DateTime? updated_datetime { get; set; }
        public DateTime? expected_datetime { get; set; }
        public string address { get; set; }
        public string address_id { get; set; }
        public string zipcode { get; set; }
        public string lat { get; set; }
        public string @long { get; set; }
        public string media_url { get; set; }
    }
}
