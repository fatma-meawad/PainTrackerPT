using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PainTrackerPT.Common.Events
{
    public interface IEventsRepo
    {
        Task<JArray> getAllEvents();
    }
}
