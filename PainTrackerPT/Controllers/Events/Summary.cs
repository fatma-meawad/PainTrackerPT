using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrackingEvents.Interfaces;

namespace TrackingEvents.Controllers
{
    public class Summary : ISummary
    {
        // This method will call a DAO to collate all the events from all tables.
        public async void getAllEvents()
        {
            EventsDAOController dao = new EventsDAOController();
            await dao.GetAllEvents();
        }
    }
}
