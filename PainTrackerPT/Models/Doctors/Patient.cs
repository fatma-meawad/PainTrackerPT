using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using PainTrackerPT.Models.Doctors;

namespace PainTrackerPT.Models.Doctors
{
    public class Patient : User
    {
        [Column(TypeName = "nvarchar(250)")]
        public string Role { get; set; }
    }
}