using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrackingEvents.Interfaces
{
    interface IEvent
    {
        void setEventTitle(String title);
        void setEventStartDate(String startDate);
        void setEventEndDate(String endDate);
    }
}
