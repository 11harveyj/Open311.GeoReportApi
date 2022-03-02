using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open311.GeoReport.Structures.Root
{
    public class Attribute
    {
        public bool variable { get; set; }
        public string code { get; set; }
        public string datatype { get; set; }
        public bool required { get; set; }
        public string datatype_description { get; set; }
        public int order { get; set; }
        public string description { get; set; }
        public Values values { get; set; }
    }
}
