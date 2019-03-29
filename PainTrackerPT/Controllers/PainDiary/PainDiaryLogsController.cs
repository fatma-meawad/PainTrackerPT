using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PainTrackerPT.Models;
using PainTrackerPT.Models.PainDiary;
using PainTrackerPT.Data;

namespace PainTrackerPT.Controllers.PainDiary
{
    public class PainDiaryLogsController : Controller
    {
        private UnitOfWork uow = new UnitOfWork();
        PainTrackerPTContext pd = new PainTrackerPTContext();

        public List<Log> GetLogs()
        {
            List<Log> log = pd.Log.ToList();
            return log.ToList();
        }


        // GET: Entry
        public ActionResult Index()
        {
            var entry = uow.EntryRepository.Get();
            return View(entry.ToList());
        }

        // GET: Entry/Details/5
        public ActionResult Details(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Entry entry = uow.EntryRepository.GetByID(id);
            if (entry == null)
            {
                return NotFound();
            }
            return View(entry);
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
        public ActionResult Create(Entry entry)
        {
            try
            {
                // Insert Logic here
                uow.EntryRepository.Insert(entry);
                uow.Save();
                return RedirectToAction(nameof(Details), new { id = entry.entryID });
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

            Entry selected = new Entry();
            selected = uow.EntryRepository.GetByID(id);

            if (selected == null)
            {
                return NotFound();
            }
            return View(selected);
        }

        // POST: Entry/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, [Bind("entryID,entryTitle,entryDescription,entryTime,painArea,painIntensity,painTime,diaryId")] Entry entry)
        {
            if (ModelState.IsValid)
            {
                // Update logic here
                uow.EntryRepository.Update(entry);
                uow.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(entry);
        }

        // GET: Entry/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Entry entry = uow.EntryRepository.GetByID(id);

            if (entry == null)
            {
                return NotFound();
            }

            return View(entry);
        }

        // POST: Entry/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            // Delete logic here
            Entry entry = uow.EntryRepository.GetByID(id);
            uow.EntryRepository.Delete(id);
            uow.Save();
            return RedirectToAction(nameof(Index));
        }

        public ActionResult View(int id)
        {
            Entry selected = new Entry();
            selected = uow.EntryRepository.GetByID(id);
            ViewBag.logs = GetLogs();
            return View(selected);
        }
    }
}
