using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PainTrackerPT.Models.Analytics.GFPatient
{
    public class PainIntensity
    {
        [Key]
        public int Id { get; set; }

        [Column("Date")]
        public DateTime Date { get; set; }

        [Column("PainRating")]
        public int PainRating { get; set; }

        [Column("PainArea")]
        public int PainArea { get; set; }

        [Column("Duration")]
        public int Duration { get; set; }

        [ForeignKey("PainDiary")]
        public int PainDiaryID { get; set; }
    }
}
