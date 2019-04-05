using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PainTrackerPT.Models;
using PainTrackerPT.Models.Doctors;
using PainTrackerPT.Services.Doctors;

namespace PainTrackerPT.Controllers.Doctors
{
    public class DoctorsLogsController : Controller
    {

        public IDoctorsLogServices DoctorsLogServices;


        public DoctorsLogsController(IDoctorsLogServices _doctorsLogServices)
        {
            DoctorsLogServices = _doctorsLogServices;
        }

        // GET: DoctorsLogs
        public async Task<IActionResult> Index()
        {
            return View(DoctorsLogServices.SelectAll());
        }

        // GET: DoctorsLogs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var doctorsLog = DoctorsLogServices.SelectById(id);
            if (doctorsLog == null)
            {
                return NotFound();
            }

            return View(doctorsLog);
        }

        // GET: DoctorsLogs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DoctorsLogs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Description,timeStamp")] DoctorsLog doctorsLog)
        {
            if (ModelState.IsValid)
            {
                DoctorsLogServices.Insert(doctorsLog);
                return RedirectToAction(nameof(Index));
            }
            return View(doctorsLog);
        }

        // GET: DoctorsLogs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var doctorsLog = DoctorsLogServices.SelectById(id);
            if (doctorsLog == null)
            {
                return NotFound();
            }
            return View(doctorsLog);
        }

        // POST: DoctorsLogs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Description,timeStamp")] DoctorsLog doctorsLog)
        {
            if (id != doctorsLog.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    DoctorsLogServices.Update(doctorsLog);
                    return RedirectToAction(nameof(Index));
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (id != doctorsLog.Id)
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(doctorsLog);
        }

        // GET: DoctorsLogs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var doctorsLog = DoctorsLogServices.SelectById(id);
            if (doctorsLog == null)
            {
                return NotFound();
            }

            return View(doctorsLog);
        }

        // POST: DoctorsLogs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {

            DoctorsLogServices.Delete(id);
            return RedirectToAction(nameof(Index));
        }

        private bool DoctorsLogExists(int id)
        {
            return (DoctorsLogServices.SelectById(id) != null);
        }
    }
}
