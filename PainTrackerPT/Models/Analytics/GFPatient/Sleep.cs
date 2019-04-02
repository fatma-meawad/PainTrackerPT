using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PainTrackerPT.Models.Analytics.GFPatient
{
    public class Sleep
    {
        [Key]
        public int Id { get; set; }

        [Column("Date")]
        public DateTime Date { get; set; }

        [Column("SleepHours")]
        public int SleepHours { get; set; }

        [Column("ComfortLevel")]
        public int ComfortLevel { get; set; }

        [Column("Tiredness")]
        public int Tiredness { get; set; }

        [ForeignKey("PainDiary")]
        public int PainDiaryID { get; set; }
    }
}
