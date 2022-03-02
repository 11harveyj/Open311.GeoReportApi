using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open311.GeoReport.Structures.ServiceRequest
{
    public class New
    {
        public string service_request_id { get; set; }
        public string token { get; set; }
        public string service_notice { get; set; }
        public string account_id { get; set; }
    }
}
