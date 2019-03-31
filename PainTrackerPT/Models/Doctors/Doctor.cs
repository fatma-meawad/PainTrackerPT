using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using PainTrackerPT.Common.Doctors;

namespace PainTrackerPT.Models.Doctors
{
    public class Doctor: IDoctorService
    {
        [Key]
        public int DoctorId { get; set; }
        public string Username { get; set; }
        public int Pin { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string EmailAdd { get; set; }
    }
}
