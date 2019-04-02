using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PainTrackerPT.Models.Analytics.GFPatient
{
    public class MedicineIntake
    {
        [Key]
        public int Id { get; set; }

        [Column("Date")]
        public DateTime Date { get; set; }

        [Column("Dosage")]
        public double Dosage { get; set; }
    }
}
