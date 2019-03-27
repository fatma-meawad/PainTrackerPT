using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PainTrackerPT.Models.Events
{
    public class Events
    {
        public Guid Id { get; set; }
        public String Description { get; set; }
        public DateTime timeStamp { get; set; }
        public string eventTitle { get; set; }
        public DateTime eventStartDate { get; set; }
        public DateTime eventEndDate { get; set; }
        public string eventDesc { get; set; }    }
}