using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using TrackingEvents.Models;

namespace TrackingEvents.Controllers
{
    public class EventsDAOController
    {
        internal TrackingEventsContext db = new TrackingEventsContext();

        public async Task<JArray> GetAllEvents()
        {
            JArray output = new JArray();

            foreach (var e in await db.Events.Include(em => em.painDiaryModule).Include(em => em.followupModule).ToListAsync())
            {
                switch (e.eventType)
                {
                    case "typePD":
                        JObject typePD = new JObject
                        {
                            { "title", e.painDiaryModule.eventName },
                            { "start", e.painDiaryModule.eventDate },
                            { "module", e.eventType },
                            { "desc", e.eventDesc },
                            {"painLevel", e.painDiaryModule.painLevel },
                        };
                        output.Add(typePD);
                        break;

                    case "typeFU":
                        JObject typeFU = new JObject
                        {
                            { "title", e.followupModule.followupTitle },
                            { "start", e.followupModule.dateGenerated },
                            { "module", e.eventType },
                            { "type", e.followupModule.followupType },
                            {"desc", e.eventDesc }
                        };
                        output.Add(typeFU);
                        break;

                    default:
                        break;
                }

            }

            return output;
        }

        public async Task<JArray> GetPDEvents()
        {
            JArray output = new JArray();

            foreach (var e in await db.Events.Include(em => em.painDiaryModule).ToListAsync())
            {

            JObject typePD = new JObject
            {
                { "title", e.painDiaryModule.eventName },
                { "start", e.painDiaryModule.eventDate },
                { "module", e.eventType },
                { "desc", e.eventDesc }
            };
            output.Add(typePD);

            }

            return output;
        }

        public async Task<JArray> GetFUEvents()
        {
            JArray output = new JArray();

            foreach (var e in await db.Events.Include(em => em.followupModule).ToListAsync())
            {

                JObject typeFU = new JObject
                {
                    { "title", e.followupModule.followupTitle },
                    { "start", e.followupModule.dateGenerated },
                    { "module", e.eventType },
                    { "type", e.followupModule.followupType },
                    { "desc", e.eventDesc }
                };
                output.Add(typeFU);

            }

            return output;
        }
    }
}