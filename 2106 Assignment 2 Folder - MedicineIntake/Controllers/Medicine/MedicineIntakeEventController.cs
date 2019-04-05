using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PainTrackerPT.Common.Medicine;
using PainTrackerPT.Interfaces.Medicine;
using PainTrackerPT.Models.Medicine;

namespace PainTrackerPT.Controllers.Medicine
{
    public class MedicineIntakeEventController : Controller 
    {
        private readonly IMedicineEventService _medService;
        private MedicineEvent _medEvent;
        private static string _medName;
        //calling API interface from Doctor team
        //private INotification _notification;

        //Dependency injection through constructor, no unnecessary initialisation needed
        public MedicineIntakeEventController(IMedicineEventService medService)//INotification notification
        {
            _medService = medService;
            //_notification = notification;
        }
       
        // GET: MedicineIntakeEvent
        public ActionResult Index(int id, string medName)
        {            
            ViewBag.ID = id;
            ViewBag.Name = medName;
            _medName = medName;
            return View(_medService.SelectMedEventById(id));            
        }

        // GET: MedicineIntakeEvent/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MedicineIntakeEvent/Create
        public ActionResult Create(int medID, string medName)
        {
            ViewBag.MedID = medID;
            ViewBag.Name = medName;
            return View();
        }

        // POST: MedicineIntakeEvent/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(int medID, [Bind("EventId,Dosage,Intervals,NumOfRecurringTimes,StartTime,MedId")] MedicineEvent medicineEvent)
        {
            _medService.Insert(medicineEvent);

            //using API from Doctor team           
            //_notification.SetNotification(medicineEvent.Dosage, medicineEvent.Intervals, medicineEvent.NumOfRecurringTimes, Request.Form["medName"]);

            return RedirectToAction("Index", "MedicineIntakeEvent", new { id = medicineEvent.MedId, medName = Request.Form["medName"] });            
        }

        // GET: MedicineIntakeEvent/Edit/5
        public ActionResult Edit(int id, int medID, string medName)

        {
            ViewBag.medID = medID;
            ViewBag.eventID = id;
            ViewBag.Name = medName;

            //retrieve Event data by passing medicine id and event id
            var eventList = _medService.GetMedicineEventList(medID, id);
            ViewBag.eventList = eventList;

            return View();
        }

        //POST: MedicineIntakeEvent/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit([Bind("EventId,Dosage,Intervals,NumOfRecurringTimes,StartTime,MedId")] MedicineEvent medicineEvent)
        {            
            if (ModelState.IsValid)
            {
                try
                {                   
                    _medService.Update(medicineEvent);
                }
                catch (DbUpdateConcurrencyException)
                {
                    throw;
                }
                return RedirectToAction("Index", "MedicineIntakeEvent", new { id = medicineEvent.MedId });
            }
            return View(medicineEvent);
        }

        // GET: MedicineEvent/Delete/5
        public async Task<IActionResult> Delete(int? id, int medID, string medName)
        {
            ViewBag.Name = medName;
            if (id == null)
            {
                return NotFound();
            }

            _medEvent = _medService.SelectById(id);

            if (_medEvent == null)
            {
                return NotFound();
            }

            return View(_medEvent);
        }

        // POST: Medicines/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed([Bind("EventId,Dosage,Intervals,NumOfRecurringTimes,StartTime,MedId")] MedicineEvent medicineEvent)
            //int id, int medID)
        {
            _medService.Delete(medicineEvent.EventId);  
            return RedirectToAction("Index", "MedicineIntakeEvent", new { id = medicineEvent.MedId, medName = Request.Form["medName"] });
        }

        // GET: Medicines/Event/
        public ActionResult Event(int id)
        {
            return null;
        }


        //These Functions will trigger when Team Huat(Healthcare Professionals) send us back with a notification 

        // GET: MedicineIntakeEvent/ViewEventLog/5
        public ActionResult ViewEventLog(int id, string medName)
        {
            ViewBag.Name = medName;

            //retrieve Event Log data by passing event id           
            return View(_medService.GetMedicineEventLogList(id));
        }       

    }
}