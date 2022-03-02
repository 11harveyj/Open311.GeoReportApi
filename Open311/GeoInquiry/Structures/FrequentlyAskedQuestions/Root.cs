using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open311.GeoInquiry.Structures.FrequentlyAskedQuestions
{
    public class Root
    {
        public string id { get; set; }
        public string question { get; set; }
        public DateTime? expiration { get; set; }
        public string url { get; set; }
        public string answer { get; set; }
        public string answer_html { get; set; }
        public Categories.Category[] categories { get; set; }
        public Service.Root[] services { get; set; }
    }
}
