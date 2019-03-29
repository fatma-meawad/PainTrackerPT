using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using PainTrackerPT.Models.Events;
using System.Threading.Tasks;

namespace PainTrackerPT.Common.Events
{
    public interface IEventsRepo
    {
        Task<JArray> getAllEvents();
        Task<JArray> getAllPainDiary();
        Task<JArray> getAllFollowUp();
        Task<JArray> getAllMedicineIntake();
        void addEvent(EventsLog e);
    }
}
