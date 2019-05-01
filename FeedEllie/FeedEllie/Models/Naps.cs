using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FeedEllie.Models
{
    public class Naps
    {
        public int id { get; set; }
        public string NapName { get; set; }
        public DateTime NapDate { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }
}