using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PainTrackerPT.Common.Medicine;
using PainTrackerPT.Models.Medicine;

namespace PainTrackerPT.Controllers.Medicine
{
    public class MedicineIntakeEventController : Controller
    {

        private readonly IMedicineService<MedicineEvent> _medService;
        private MedicineEvent _medEvent = new MedicineEvent();

        public MedicineIntakeEventController(IMedicineService<MedicineEvent> medService)
        {
            _medService = medService;
        }

        // GET: MedicineIntakeEvent
        public ActionResult Index(int id)
        {
            //if (id == null)
            //{
            //    return NotFound();
            //}

            //_medEvent = _medService.SelectById(id);

            //if (_medEvent == null)
            //{
            //    return NotFound();
            //}
            //return View(_medEvent);
            ViewBag.ID = id;
            return View(_medService.SelectAll());
        }

        // GET: MedicineIntakeEvent/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MedicineIntakeEvent/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MedicineIntakeEvent/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(int id, [Bind("EventId,Dosage,Timestamp")] MedicineEvent medicineEvent)
        {
            try
            {
                // TODO: Add insert logic here
                if (ModelState.IsValid)
                {
                    medicineEvent.MedId = id;
                    _medService.Insert(medicineEvent);
                    return RedirectToAction(nameof(Index));
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MedicineIntakeEvent/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MedicineIntakeEvent/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MedicineIntakeEvent/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MedicineIntakeEvent/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}