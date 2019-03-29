using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PainTrackerPT.Common.Medicine;
using PainTrackerPT.Models;
using PainTrackerPT.Models.Medicine;

namespace PainTrackerPT.Controllers.Medicine
{
    public class MedicineLogController : Controller
    {
        private readonly IMedicineService<MedicineLog> _medService;
        private MedicineLog _medLog;

        public MedicineLogController(IMedicineService<MedicineLog> medService)
        {
            _medService = medService;         
        }
              
        
        // GET: MedicineLogs/Details/5
        public ActionResult Details(DateTime dt)
        {            
            return View(_medService.GetLogAt(dt));
            
        }
       
        //GET: MedicineLogs
        public async Task<IActionResult> Index()
        {
            //return View(_medService.SelectAll());
            return View(_medService.SelectMedLogById(1,1));
        }

        // GET: MedicineLogs/Create
        public IActionResult Create()
        {
            var medNameList = _medService.GetMedicineNameList();
            ViewData["medNameList"] = medNameList;
            return View();
        }

        // POST: MedicineLogs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(int id, [Bind("Id,Name,Type,timeStamp")] MedicineLog medicineLog)
        {
            if (ModelState.IsValid)
            {               
                _medService.Insert(medicineLog);
                return RedirectToAction(nameof(Index));
            }
            return View(medicineLog);
        }

        // GET: Medicines/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            _medLog = _medService.SelectById(id);

            if (_medLog == null)
            {
                return NotFound();
            }
            return View(_medLog);
        }

        //POST: MedicineLogs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id,[Bind("Id,Name,Type,timeStamp")] MedicineLog medicineLog)
        {
            if (id != medicineLog.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _medService.Update(medicineLog);                   
                }
                catch (DbUpdateConcurrencyException)
                {                    
                    throw;                    
                }
                return RedirectToAction(nameof(Index));
            }
            return View(medicineLog);
        }

        // GET: MedicineLogs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            _medLog = _medService.SelectById(id);

            if (_medLog == null)
            {
                return NotFound();
            }

            return View(_medLog);
        }

        // POST: Medicines/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            _medService.Delete(id);
            return RedirectToAction(nameof(Index));
        }

        // GET: Medicines/Event/
        public ActionResult Event(int id)
        {
            return null;
        }
    }
}
