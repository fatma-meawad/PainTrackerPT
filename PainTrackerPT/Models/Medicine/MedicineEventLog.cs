using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PainTrackerPT.Models.Medicine
{
    public class MedicineEventLog
    {
        [Key]
        public int LogId { get; set; }

        public int Dosage { get; set; }
        public DateTime CurrentTime { get; set; }

        [Required]
        [ForeignKey("MedicineEvent")]
        public int EventId { get; set; }
        public int MedId { get; set; }
    }
}
