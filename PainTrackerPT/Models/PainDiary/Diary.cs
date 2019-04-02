using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PainTrackerPT.Models.PainDiary
{
    [Table("Diary")]
    public class Diary
    {
        [Display(Name = "Diary ID")]
        public int diaryID { get; set; }

        [Display(Name = "Diary Title")]
        public String diaryTitle { get; set; }

        [Display(Name = "Creation Date")]
        [DataType(DataType.Date)]
        public DateTime creationDate { get; set; }

        [Display(Name = "Diary Permission")]
        public Boolean diaryPermission { get; set; }

    }
}
