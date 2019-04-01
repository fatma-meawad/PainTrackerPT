using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PainTrackerPT.Models.Doctors
{
    public class Login
    {
        [Key]
        public int UserID { get; set; }
        public string Username { get; set; }
        
        [DataType(DataType.Password)]
        public int Pin { get; set; }


        public string LoginError { get; set; }
    }
}
