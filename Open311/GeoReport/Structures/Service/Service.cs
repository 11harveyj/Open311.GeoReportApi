using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open311.GeoReport.Structures.Service
{
    public class Root
    {
        public string service_code { get; set; }
        public string service_name { get; set; }
        public string description { get; set; }
        public bool metadata { get; set; }
        public string type { get; set; }
        public string[] keywords { get; set; }
        public string group { get; set; }
    }
}
