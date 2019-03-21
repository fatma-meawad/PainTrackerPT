using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TrackingEvents.Models
{
    public class Events
    {
        [Required]
        public int Id { get; set; }
        public string eventType { get; set; }
        public string eventDesc { get; set; }
        public virtual PainDiary painDiaryModule { get; set; } // Foreign key
        public virtual Followup followupModule { get; set; } // Foreign key
    }
}