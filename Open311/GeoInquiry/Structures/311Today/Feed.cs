using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open311.GeoInquiry.Structures._311Today
{
    public class Item
    {
        public string title { get; set; }
        public DateTime pubDate { get; set; }
        public string guid { get; set; }
        public string content_encoded { get; set; }
        public DateOnly? dc_coverage { get; set; }
    }
    public class Channel
    {
        public string title { get; set; }
        public string link { get; set; }
        public string description { get; set; }
        public Item[] item { get; set; }
    }
    public class Feed
    {
        public Channel[] channel { get; set; }
    }
}
