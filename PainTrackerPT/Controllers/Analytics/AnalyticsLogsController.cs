using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PainTrackerPT.Data.Analytics;
using PainTrackerPT.Models.Analytics;
using analyticsModel = PainTrackerPT.Models.Analytics.GFPatient;
using PainTrackerPT.Trends;
using PainTrackerPT.Trends.Aggregate;

namespace PainTrackerPT.Controllers
{
    public class AnalyticsLogsController : Controller
    {

        private readonly IGinyuGateway _gateway;
        private readonly IGFPatientGateway _patientGateway;
        private readonly IGFPatientMedicineIntakeGateway _patientMedicineIntakeGateway;

        public AnalyticsLogsController(IGinyuGateway gateway, IGFPatientGateway _patient, IGFPatientMedicineIntakeGateway _medicineIntake)
        {
            _gateway = gateway;
            _patientGateway = _patient;
            _patientMedicineIntakeGateway = _medicineIntake;
        }

        public async Task<ActionResult> PatientTrend()
        {
            analyticsModel.PainDiary PainDiary = _patientGateway.SelectById(1);
            List<analyticsModel.MedicineIntake> Mitl = _patientMedicineIntakeGateway.SelectAll();

            //All trends related to PainDiary
            IPatientTrend PainIntensityTrend = new PainIntensityTrend(PainDiary.PainIntensity);
            IPatientTrend SleepTrend = new SleepTrend(PainDiary.Sleep);
            IPatientTrend MoodTrend = new MoodTrend(PainDiary.Mood);
            IPatientTrend InterferenceTrend = new InterferenceTrend(PainDiary.Interference);

            //Trends related to MedicineIntake
            IPatientTrend MedicineIntakeTrend = new MedicineIntakeTrend(Mitl);

            //Plot SuperImposed Graph in view
            ViewBag.PainIntensityPlots = PainIntensityTrend.PlotGraph();
            ViewBag.InterferencePlots = InterferenceTrend.PlotGraph();
            ViewBag.MoodPlots = MoodTrend.PlotGraph();
            ViewBag.SleepPlots = SleepTrend.PlotGraph();
            ViewBag.MedicineIntakePlots = MedicineIntakeTrend.PlotGraph();


            //Send PieChart data to frontend

            return View();
        }

        // GET: AnalyticsLogs
        public async Task<IActionResult> Index()
        {
            //Currently Retrieving a specific user information for testing    
            return View(_gateway.SelectAll());
            //return View(_patientGateway.SelectById(1));
        }

        // GET: AnalyticsLogs/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var analyticsLog = _gateway.Find(id);

            if (analyticsLog == null)
            {
                return NotFound();
            }

            return View(analyticsLog);
        }

        // GET: AnalyticsLogs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AnalyticsLogs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Description,timeStamp")] AnalyticsLog analyticsLog)
        {
            if (ModelState.IsValid)
            {
                analyticsLog.Id = Guid.NewGuid();

                _gateway.Insert(analyticsLog);
                _gateway.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(analyticsLog);
        }

        // GET: AnalyticsLogs/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var analyticsLog = _gateway.Find(id);
            if (analyticsLog == null)
            {
                return NotFound();
            }
            return View(analyticsLog);
        }

        // POST: AnalyticsLogs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,Description,timeStamp")] AnalyticsLog analyticsLog)
        {
            if (id != analyticsLog.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _gateway.Update(analyticsLog);
                    _gateway.Save();

                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AnalyticsLogExists(analyticsLog.Id))
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
            return View(analyticsLog);
        }

        // GET: AnalyticsLogs/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var analyticsLog = _gateway.Find(id);
            if (analyticsLog == null)
            {
                return NotFound();
            }

            return View(analyticsLog);
        }

        // POST: AnalyticsLogs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            _gateway.Delete(id);
            _gateway.Save();
            return RedirectToAction(nameof(Index));
        }

        private bool AnalyticsLogExists(Guid id)
        {
            return _gateway.Exist(id);
        }
    }
}
