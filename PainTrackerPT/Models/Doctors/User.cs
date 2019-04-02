using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PainTrackerPT.Models.Doctors
{
    public class User
    {

        [Key, Column("UserId", Order = 1)]
        public int UserId { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        public string Pin { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        public string Username { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        public string Firstname { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        public string Lastname { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        public string EmailAdd { get; set; }

    }
}
