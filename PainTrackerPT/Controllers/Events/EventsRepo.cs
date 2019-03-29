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

        public void addEvent(EventsLog e)
        {
            throw new NotImplementedException();
        }

        public async Task<JArray> getAllEvents()
        {
            JArray output = new JArray();

            string query = "SELECT * FROM dbo.Events";

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

            string query = "SELECT * FROM dbo.Events WHERE moduleType='typePD'";

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

            string query = "SELECT * FROM dbo.Events WHERE moduleType='typeFU'";

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

        public async Task<JArray> getAllMedicineIntake()
        {
            JArray output = new JArray();

            string query = "SELECT * FROM dbo.Events WHERE moduleType='typeMI'";

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
