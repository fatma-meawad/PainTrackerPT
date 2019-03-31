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
        public int AppointmentId { get; set; }
        public int PatientID { get; set; }
        public int DoctorID { get; set; }

        public string Message { get; set; }

        public string AppDate { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd HH:MM. HH}")]
        public string ProposedDate { get; set; }
        public string ApptLocation { get; set; }

        public bool docCfm { get; set; }
        public bool patCfm { get; set; }

        public bool pdAttach { get; set; }
        public bool miAttach { get; set; }

        public string status { get; set; }

    }
}