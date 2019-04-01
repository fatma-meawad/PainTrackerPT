using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PainTrackerPT.Models;
using PainTrackerPT.Models.Doctors;



namespace PainTrackerPT.Controllers.Doctors
{
    public class PatientsController : Controller
    {
        
        private readonly PainTrackerPTContext _context;

        public PatientsController(PainTrackerPTContext context)
        {
            _context = context;
        }

        // GET: Dashboard
        public ActionResult PatientAppointment_Dashboard()
        {
            
            return View();
        }

        // GET: Appointments/Edit/5
        public async Task<ActionResult> PatientAppointment()
        {
            var patientId = 123;
            
            var appointment = await _context.Appointments.Where(u => u.PatientID == patientId ).ToListAsync();

            foreach (var item in appointment)
            {
                if (item.PatientID == 123)
                {
                    if (item.status == "Pending")
                    {
                        return View("PatientAppointmentPending_Edit", item);
                    }
                    else if (item.status == "AwaitingPatCfm")
                    {
                        return View("PatientAppointmentAwaitingPatCfm_Edit", item);
                    }
                    else if (item.status == "AwaitingDocCfm")
                    {
                        return View("PatientAppointmentAwaitingDocCfm_Edit", item);
                    }
                    else if (item.status == "ApptCfm")
                    {
                        return View("PatientAppointmentApptCfm_Edit", item);
                    }

                }
            }
            // return error message AwaitingPatCfm
            ViewBag.Error = "appointmentError";
            return View("PatientAppointment_Dashboard");
        }

        // GET: Appointments/Edit/5
        // edit message only
        // status: Pending -> Pending
        public ActionResult PatientAppointmentPending_Edit(Appointment appointment )
        {
            return View(appointment);
        }

        // GET: Appointments/Edit/5
        // cfm appt or propose a new date
        // status : AwaitingPatCfm -> ApptCfm
        // status : AwaitingPatCfm -> Propose new appt date(AwaitingPatCfm)
        public ActionResult PatientAppointmentApptCfm_Edit(Appointment appointment)
        {
            return View(appointment);
        }

        // GET: Appointments/Edit/5
        // Patient propose a new date
        // status : AwaitingPatCfm -> AwaitingDocCfm
        public async Task<ActionResult> PatientAppointmentPatProposeNewDate_Edit()
        {
            var patientId = 123;

            var appointment = await _context.Appointments.Where(u => u.PatientID == patientId).ToListAsync();
            foreach (var item in appointment)
            {
                if (item.PatientID == 123)
                {
                    return View(item);
                }
            }
            return NotFound();
        }

        // GET: Appointments/Edit/5
        public ActionResult PatientAppointmentAwaitingPatCfm_Edit(Appointment appointment)
        {

            return View(appointment);
        }



        // GET: Appointments/Edit/5
        public ActionResult PatientAppointmentAwaitingDocCfm_Edit(Appointment appointment)
        {

            return View(appointment);
        }


        // POST: Appointments/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> PatientAppointment_Edit(int id, [Bind("AppointmentId,PatientID,DoctorID,Message,AppDate,ProposedDate,ApptLocation,docCfm,patCfm,pdAttach,miAttach,status")] Appointment appointment)
        {


            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(appointment);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AppointmentExists(appointment.AppointmentId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(PatientAppointment));
            }
            return View(appointment);
        }



        // GET: Appointments
        public async Task<IActionResult> PatientAppointment_Index()
        {
            var id = 123;
            var appointment = await _context.Appointments.Where(u => u.PatientID == id && u.ApptLocation == null).ToListAsync();
            //var appointment = await _context.Appointments.ToListAsync();
            return View(appointment);
        }

        // GET: Appointments
        public async Task<IActionResult> PatientAppointmentPending_Index()
        {
            var id = 123;
            var appointment = await _context.Appointments.Where(u => u.ApptLocation != null && u.PatientID == id).ToListAsync();
            //var appointment = await _context.Appointments.ToListAsync();
            return View(appointment);
        }

        // GET: Appointments
        public async Task<IActionResult> PatientAppointmentCfm_Index()
        {
            var id = 123;
            var appointment = await _context.Appointments.Where(u => u.ApptLocation != null && u.PatientID == id && u.AppDate !=null).ToListAsync();
            //var appointment = await _context.Appointments.ToListAsync();
            return View(appointment);
        }

        // GET: Appointments/Details/5
        public async Task<IActionResult> PatientAppointment_Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var appointment = await _context.Appointments
                .FirstOrDefaultAsync(m => m.AppointmentId == id);
            if (appointment == null)
            {
                return NotFound();
            }

            return View(appointment);
        }

        // GET: Appointments/Create
        public async Task<IActionResult> PatientAppointment_Create()
        {
            var id = 123;
            var appointment = await _context.Appointments.ToListAsync();

            foreach (var item in appointment)
            {
                if (item.PatientID == id)
                {
                    ViewBag.Error = "createError";
                    return View("PatientAppointment_Dashboard");
                }
            }

            return View();
        }

        // POST: Appointments/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> PatientAppointment_Create([Bind("AppointmentId,PatientID,DoctorID,Message,AppDate,ProposedDate,ApptLocation,docCfm,patCfm,pdAttach,miAttach,status")] Appointment appointment)
        {
            if (ModelState.IsValid)
            {
                _context.Add(appointment);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(PatientAppointment));
            }
            return View(appointment);
        }




        // GET: Appointments/Delete/5
        public async Task<IActionResult> PatientAppointment_Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var appointment = await _context.Appointments
                .FirstOrDefaultAsync(m => m.AppointmentId == id);
            if (appointment == null)
            {
                return NotFound();
            }

            return View(appointment);
        }

        // POST: Appointments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> PatientAppointment_DeleteConfirmed(int id)
        {
            var appointment = await _context.Appointments.FindAsync(id);
            _context.Appointments.Remove(appointment);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(PatientAppointment_Index));
        }


        // GET: Appointments/Edit/5
        public async Task<IActionResult> PatientAppointmentPending_Accept(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var appointment = await _context.Appointments.FindAsync(id);
            if (appointment == null)
            {
                return NotFound();
            }
            return View(appointment);
        }

        // POST: Appointments/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> PatientAppointmentPending_Accept(int id, [Bind("AppointmentId,PatientID,DoctorID,Message,AppDate,ProposedDate,ApptLocation,docCfm,patCfm,pdAttach,miAttach")] Appointment appointment)
        {
            if (id != appointment.AppointmentId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(appointment);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AppointmentExists(appointment.AppointmentId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(PatientAppointment_Index));
            }
            return View(appointment);
        }

        public ActionResult errorModalPopUp()
        {
            return View();
        }

        private bool AppointmentExists(int id)
        {
            return _context.Appointments.Any(e => e.AppointmentId == id);
        }

    }
}
