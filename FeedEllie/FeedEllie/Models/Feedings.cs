using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FeedEllie.Models
{
    public class Feedings
    {
        public int Id { get; set; }
        public string FeedName { get; set; }
        public DateTime FeedDate { get; set; }
        public string FeedTime { get; set; }
        public string Food { get; set; }
    }
}