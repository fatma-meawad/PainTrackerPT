using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PainTrackerPT.Models.PainDiary
{
    [Table("Log")]
    public class Log
    {
        [Display(Name = "Log ID")]
        public int logID { get; set; }

        [Display(Name = "Log Time")]
        [DataType(DataType.Date)]
        public DateTime logTime { get; set; }

        [Display(Name = "Written Notes")]
        public String writtenNotes { get; set; }

        [Display(Name = "Audio Notes")]
        public String audioNotes { get; set; }

        [Display(Name = "Mood")]
        public String mood { get; set; }

        [Display(Name = "Entry ID (FK)")]
        [ForeignKey("Entry")]
        public int entryId { get; set; }
    }
}
