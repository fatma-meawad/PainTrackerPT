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
using System.IO;

namespace PainTrackerPT.Controllers.Events
{
    public class EventsRepo: Controller, IEventsRepo
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

        private bool EventsLogExists(Guid id)
        {
            return db.EventsLog.Any(e => e.Id == id);
        }

        public async Task<JArray> getAllEvents()
        {
            JArray output = new JArray();

            string query = "SELECT * FROM dbo.EventsLog";

            foreach (var e in await db.EventsLog.FromSql(query).ToListAsync())
            {
                JObject evt = new JObject
                {
                    { "id", e.Id },
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
                    { "id", e.Id },
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
                    { "id", e.Id },
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
                    { "id", e.Id },
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

        public void exportToCSVfile()
        {
            var data = db.EventsLog.ToList();

            // Set a variable to the Documents path.
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            // Write the data to csv file name".
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "Events.csv")))
            {
                outputFile.WriteLine(string.Format("\"Subject\",\"Start Date\",\"Start Time\",\"End Date\",\"End Time\",\"Description\""));
                foreach (var e in data)

                    outputFile.WriteLine(string.Format("\"{0}\",\"{1}\",\"{2}\",\"{3}\",\"{4}\",\"{5}\"",
                                              e.eventTitle,
                                              e.eventStartDate.ToString("dd-MM-yyyy"),
                                              e.eventStartDate.ToString("HH:mm"),
                                              e.eventEndDate.ToString("dd-MM-yyyy"),
                                              e.eventEndDate.ToString("HH:mm"),
                                              e.eventDesc));
            }



        }

        public async void editDesc(Guid id, EventsLog e)
        {
            if (id != e.Id)
            {
                return;
            }
            if (ModelState.IsValid)
            {
                try
                {
                    var eventLog = await db.EventsLog.FirstOrDefaultAsync(m => m.Id == e.Id);
                    eventLog.eventDesc = e.eventDesc;
                    db.Update(eventLog);
                    await db.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EventsLogExists(e.Id))
                    {
                        return; // Not found
                    }
                    else
                    {
                        throw;
                    }
                }
            }
        }

    }
}
