using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PainTrackerPT.Models.Doctors
{
    public class Notification
    {
        [Key]
        public int NotificationId { get; set; }
        public string Role { get; set; }
        public int UserId { get; set; }
        public string Header { get; set; }
        public string Message { get; set; }
        public bool Viewed { get; set; }
    }
}
