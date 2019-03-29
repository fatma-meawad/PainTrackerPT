using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PainTrackerPT.Models.Events
{
    public class EventsLog
    {
       public Guid Id { get; set; }
        public DateTime timeStamp { get; set; }
        public string eventTitle { get; set; }
        public DateTime eventStartDate { get; set; }
        public DateTime eventEndDate { get; set; }
        public string eventDesc { get; set; }
        public string moduleType { get; set; }
    }
}
