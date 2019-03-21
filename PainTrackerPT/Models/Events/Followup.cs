using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TrackingEvents.Models
{
    public class Followup
    {
        [Required]
        public int Id { get; set; }
        public string followupTitle { get; set; }
        public DateTime dateGenerated { get; set; }
        public string followupType { get; set; }
    }
}
