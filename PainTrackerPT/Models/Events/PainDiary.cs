using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace TrackingEvents.Models
{
    public class PainDiary
    {
        [Required]
        public int Id { get; set; }
        public string eventName { get; set; }
        public DateTime eventDate { get; set; }
        public int painLevel { get; set; }
    }
}
