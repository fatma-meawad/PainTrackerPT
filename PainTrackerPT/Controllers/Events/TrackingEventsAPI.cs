using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrackingEvents.Models;

namespace TrackingEvents.Controllers
{
    public class TrackingEventsAPI : ITrackingEventsAPI
    {
        internal TrackingEventsContext db = new TrackingEventsContext();

        public void addFollowUpEvent(Followup module)
        {
            Events e = new Events();
            e.eventType = "typeFU";
            e.followupModule = module;
            db.Events.Add(e);
            db.SaveChanges();
        }

        public void addPainDairyEvent(PainDiary module)
        {
            Events e = new Events();
            e.eventType = "typePD";
            e.painDiaryModule = module;
            db.Events.Add(e);
            db.SaveChanges();
        }

        public void updateEventDesc(int id, Events module)
        {
            Events e = new Events();
            e.Id = id;
            e.eventType = "typeFU";
            e.eventDesc = module.eventDesc;
            db.Events.Update(e);
            db.SaveChanges();
        }
    }
}
