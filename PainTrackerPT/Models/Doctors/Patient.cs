using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PainTrackerPT.Models.Doctors
{
    public class Patient
    {
        [Key]
        public int PatientId { get; set; }
        [Column(TypeName ="nvarchar(250)")]
        public string Username { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        public string Pin { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        public string Firstname { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        public string Lastname { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        public string EmailAdd { get; set; }
    }
}