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
    public class PainDiaryController : Controller
    {

        private UnitOfWork uow = new UnitOfWork();

        // GET: Diary/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Diary/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Diary diary)
        {
            try
            {
                // Insert Logic here
                uow.DiaryRepository.Insert(diary);
                uow.Save();
                return RedirectToAction(nameof(Details), new { id = diary.diaryID });
            }
            catch
            {
                return View(diary);
            }
        }

        // GET: Diary/Details/5
        public ActionResult Details(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Diary diary = uow.DiaryRepository.GetByID(id);
            if (diary == null)
            {
                return NotFound();
            }
            return View(diary);
        }

    }
}