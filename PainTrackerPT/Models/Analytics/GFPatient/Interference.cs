using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PainTrackerPT.Models.Analytics.GFPatient
{
    public class Interference
    {
        [Key]
        public int Id { get; set; }

        [Column("Date")]
        public DateTime Date { get; set; }

        [Column("Description")]
        public string Description { get; set; }

        [Column("Severity")]
        public int Severity { get; set; }

        [Column("Duration")]
        public int Duration { get; set; }

        [ForeignKey("PainDiary")]
        public int PainDiaryID { get; set; }




    }
}
