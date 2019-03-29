using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using PainTrackerPT.Common.Events;
using PainTrackerPT.Models.Events;
using System.Linq;
using System.Threading.Tasks;

namespace PainTrackerPT.Controllers
{
    public class EventsController : Controller
    {
        private readonly IEventsRepo _eRepo;

        public EventsController(IEventsRepo eRepo)
        {
            _eRepo = eRepo;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            JArray output = await _eRepo.getAllEvents();
            return Json(output);

        }

        [HttpGet]
        public async Task<ActionResult> GetPainDairy()
        {
            JArray output = await _eRepo.getAllPainDiary();
            return Json(output);
        }

        [HttpGet]
        public async Task<ActionResult> GetFollowUp()
        {
            JArray output = await _eRepo.getAllFollowUp();
            return Json(output);

        }

        [HttpGet]
        public async Task<ActionResult> GetMedicineIntake()
        {
            JArray output = await _eRepo.getAllMedicineIntake();
            return Json(output);

        }
        
        // POST: Events/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public void Create([Bind("eventTitle,eventStartDate,eventEndDate,eventDesc,moduleType")] EventsLog e)
        {
            _eRepo.addEvent(e);
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
