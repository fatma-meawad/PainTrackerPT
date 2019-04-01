using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PainTrackerPT.Models.Analytics.GFPatient
{
    public class PainIntensity
    {
        [Key]
        public int id { get; set; }

        [Column("Date")]
        public DateTime date { get; set; }

        [Column("PainRating")]
        public int painRating { get; set; }

        [Column("PainArea")]
        public int painArea { get; set; }

        [Column("Duration")]
        public int duration { get; set; }

        [ForeignKey("PainDiary")]
        public int PainDiaryID { get; set; }
    }
}
