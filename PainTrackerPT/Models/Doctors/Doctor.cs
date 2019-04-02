using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using PainTrackerPT.Common.Doctors;
using PainTrackerPT.Models.Doctors;

namespace PainTrackerPT.Models.Doctors
{
    public class Doctor : User
    {
        [Column(TypeName = "nvarchar(250)")]
        public string Role { get; set; }
    }
}