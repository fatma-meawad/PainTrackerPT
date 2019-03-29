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

            string query = "SELECT * FROM dbo.EventsLog";

            foreach (var e in await db.EventsLog.FromSql(query).ToListAsync())
            {
                JObject evt = new JObject
                {
                    { "title", e.eventTitle },
                    { "start", e.eventStartDate },
                    { "end", e.eventEndDate },
                    { "desc", e.eventDesc },
                    { "type", e.moduleType }
                };

                output.Add(evt);
            }

            return output;
        }

        public async Task<JArray> getAllPainDiary()
        {
            JArray output = new JArray();

            string query = "SELECT * FROM dbo.EventsLog WHERE moduleType='PD'";

            foreach (var e in await db.EventsLog.FromSql(query).ToListAsync())
            {
                JObject evt = new JObject
                {
                    { "title", e.eventTitle },
                    { "start", e.eventStartDate },
                    { "end", e.eventEndDate },
                    { "desc", e.eventDesc },
                    { "type", e.moduleType }
                };

                output.Add(evt);
            }

            return output;
        }

        public async Task<JArray> getAllFollowUp()
        {
            JArray output = new JArray();

            string query = "SELECT * FROM dbo.EventsLog WHERE moduleType='FU'";

            foreach (var e in await db.EventsLog.FromSql(query).ToListAsync())
            {
                JObject evt = new JObject
                {
                    { "title", e.eventTitle },
                    { "start", e.eventStartDate },
                    { "end", e.eventEndDate },
                    { "desc", e.eventDesc },
                    { "type", e.moduleType }
                };

                output.Add(evt);
            }

            return output;
        }

        public async Task<JArray> getAllMedicineIntake() {
            JArray output = new JArray();

            string query = "SELECT * FROM dbo.EventsLog WHERE moduleType='MI'";

            foreach (var e in await db.EventsLog.FromSql(query).ToListAsync())
            {
                JObject evt = new JObject
                {
                    { "title", e.eventTitle },
                    { "start", e.eventStartDate },
                    { "end", e.eventEndDate },
                    { "desc", e.eventDesc },
                    { "type", e.moduleType }
                };

                output.Add(evt);
            }

            return output;
        }


    }
}
