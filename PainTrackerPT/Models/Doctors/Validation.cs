using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PainTrackerPT.Models.Doctors
{
    public class Validation
    {
        public string Username { get; set; }

        [DataType(DataType.Password)]
        public int Pin { get; set; }


        public string LoginError { get; set; }
    }
}
