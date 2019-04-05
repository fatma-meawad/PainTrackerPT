using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PainTrackerPT.Models;
using PainTrackerPT.Models.PainDiary;
using PainTrackerPT.Services;

namespace PainTrackerPT.Controllers.PainDiary
{
    public class PainDiaryLogsController : Controller
    {

        public PainDiaryLogService PainDiaryLogService;

        public PainDiaryLogsController(PainDiaryLogService painDiaryLogServices)
        {
            PainDiaryLogService = painDiaryLogServices;
        }
        /*
         * Entry Controller 
         */

        // GET: Entry
        public ActionResult Index()
        {

            return View(PainDiaryLogService.Get());
        }

        // GET: Entry/Details/5
        public ActionResult Details(int id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var pdl = PainDiaryLogService.GetByID(id);
            if (pdl == null)
            {
                return NotFound();
            }

            return View(pdl);
        }

        // GET: Entry/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Entry/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PainDiaryLog pdl)
        {
            try
            {
                // Insert Logic here
                PainDiaryLogService.Insert(pdl);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Entry/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var pdl = PainDiaryLogService.GetByID(id);
            if (pdl == null)
            {
                return NotFound();
            }

            return View(pdl);
        }

        // POST: Entry/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, PainDiaryLog pdl)
        {
            if (ModelState.IsValid)
            {
                // Update logic here
                PainDiaryLogService.Update(pdl);
                return RedirectToAction(nameof(Index));
            }
            return View(pdl);
        }

        // GET: Entry/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var pdl = PainDiaryLogService.GetByID(id);
            if (pdl == null)
            {
                return NotFound();
            }

            return View(pdl);
        }

        // POST: Entry/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            // Delete logic here
            PainDiaryLogService.Delete(id);
            return RedirectToAction(nameof(Index));
        }

    }
}
