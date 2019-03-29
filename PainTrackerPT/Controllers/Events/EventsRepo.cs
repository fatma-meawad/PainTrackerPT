using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using PainTrackerPT.Models;
using PainTrackerPT.Models.Events;
using PainTrackerPT.Common.Events;

namespace PainTrackerPT.Controllers.Events
{
    public class EventsRepo: IEventsRepo
    {
        //private readonly PainTrackerPTContext _context;

        //public EventsRepo(PainTrackerPTContext context)
        //{
        //    _context = context;
        //}

        internal PainTrackerPTContext db = new PainTrackerPTContext();

        public async void addEvent(EventsLog e)
        {
            Guid g;
            g = Guid.NewGuid();
            e.Id = g;
            e.timeStamp = DateTime.Now;
            db.Add(e);
            await db.SaveChangesAsync();
        }

        public async Task<JArray> getAllEvents()
        {
            JArray output = new JArray();

            foreach (var e in await db.EventsLog.ToListAsync())
            {
                JObject evt = new JObject
                {
                    { "title", e.eventTitle },
                    { "start", e.eventStartDate },
                    { "end", e.eventEndDate },
                    { "desc", e.eventDesc }
                };

                output.Add(evt);
            }

            return output;
        }

    }
}
