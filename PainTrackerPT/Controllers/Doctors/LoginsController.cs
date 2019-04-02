using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PainTrackerPT.Models;
using PainTrackerPT.Models.Doctors;

namespace PainTrackerPT.Controllers.Doctors
{
    public class LoginsController : Controller
    {
        private readonly PainTrackerPTContext _context;

        public LoginsController(PainTrackerPTContext context)
        {
            _context = context;
        }
        // GET: Login
        public ActionResult Login()
        {


            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Autherize(PainTrackerPT.Models.Doctors.User xxx)
        {
            var userDetailsPatients = _context.User.Where(x => x.Username == xxx.Username && x.Pin == xxx.Pin).FirstOrDefault();
            //var userDetailsDoctors = _context.User.Where(x => x.Username == xxx.Username && x.Pin == xxx.Pin).FirstOrDefault();
            //var userDetailsAdmin = _context.Admins.Where(x => x.Username == xxx.Username && x.Pin == xxx.Pin).FirstOrDefault();




            if (userDetailsPatients != null)
            {
                //ViewBag.Role = "Patient";

                //TempData["Role"] = "doctor";
                
                return RedirectToAction("Index", "Home");
            }

            ViewBag.Error = "Invalid username or password";

            return View("Login", xxx);
        }



    }
}
