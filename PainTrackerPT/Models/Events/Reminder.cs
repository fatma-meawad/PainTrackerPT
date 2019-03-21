using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TrackingEvents.Models
{
    public class Reminder
    {
        [Required]
        public int Id { get; set; }
        public DateTime firstReminder { get; set; }
        public string firstReminderDesc { get; set; }
        public int eventID { get; set; }
    }
}
