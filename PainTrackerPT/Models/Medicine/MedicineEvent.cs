using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PainTrackerPT.Models.Medicine
{
    public class MedicineEvent
    {
        [Key]
        public int EventId { get; set; }
        [Required]
        public int Dosage { get; set; }
        public DateTime StartTime { get; set; }
        public int Intervals { get; set; }
        public int NumOfRecurringTimes { get; set; }
        
        [Required]
        [ForeignKey("MedicineLog")]
        public int MedId { get; set; }


    }
}
