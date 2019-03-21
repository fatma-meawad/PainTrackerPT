using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrackingEvents.Controllers;

namespace TrackingEvents
{
    public class Calendar : ICalendar
    {
        // This method will get a summary of events
        public void getSummary() {
            Summary s = new Summary();
            s.getAllEvents();
        }
    }
}

