using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PainTrackerPT.Models.Doctors
{
    public class Appointment
    {
        [Key]
        public int PatientID { get; set; }
        public int DoctorID { get; set; }


        public string Message { get; set; }
        public string AppDate { get; set; }
        public string ProposedDate { get; set; }
        public string ApptLocation { get; set; }

    }
}