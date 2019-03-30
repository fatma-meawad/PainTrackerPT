using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PainTrackerPT.Models.Analytics.GFPatient
{
    public class PainDiary
    {
        [Key]
        public int PainDiaryID { get; set; }

        [ForeignKey("Patient")]
        public int PatientID { get; set; }
     

        public virtual List<Interference> Interference { get; set; }
        public virtual List<Mood> Mood { get; set; }
        public virtual List<Sleep> Sleep { get; set; }
        public virtual List<PainIntensity> PainIntensity { get; set; }    

    }
}
