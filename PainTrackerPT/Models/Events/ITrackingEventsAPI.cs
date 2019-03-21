using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrackingEvents.Models
{
    interface ITrackingEventsAPI
    {
        // NEED TO ADD OR MODIFY TO WORK
        void addFollowUpEvent(Followup moduleID);
        void addPainDairyEvent(PainDiary moduleID);

    }
}
