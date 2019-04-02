using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PainTrackerPT.Data;
using PainTrackerPT.Models.PainDiary;

namespace PainTrackerPT.Controllers.PainDiary
{
    public class PainLogController : Controller
    {

        private UnitOfWork uow = new UnitOfWork();

         /*
        * Start of Log Controller
        */

        // GET: Log/Create
        public ActionResult Create(int? id)
        {

           ViewBag.entryId = id;
           return View();
        }

        // POST: Diary/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Log log)
        {
            try
            {
                // Insert Logic here
                uow.LogRepository.Insert(log);
                uow.Save();
                return RedirectToAction(nameof(Details), new { id = log.logID });
            }
            catch
            {
                return View(log);
            }
        }

        // GET: Log/Details/5
        public ActionResult Details(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Log log = uow.LogRepository.GetByID(id);
            if (log == null)
            {
                return NotFound();
            }
            return View(log);
        }

        // GET: Log/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Log log = uow.LogRepository.GetByID(id);

            if (log == null)
            {
                return NotFound();
            }

            return View(log);
        }

        // POST: Log/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            // Delete logic here
            Log log = uow.LogRepository.GetByID(id);
            uow.LogRepository.Delete(id);
            uow.Save();
            return RedirectToAction("Index", "PainEntry");
        }
    }
}