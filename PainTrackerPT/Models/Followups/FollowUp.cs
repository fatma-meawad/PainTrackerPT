using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PainTrackerPT.Models.Followups
{
    public class FollowUp : BaseEntity
    {
        public Guid PatientId { get; set; }
        public Guid DoctorId { get; set; }
        [Required]
        [Range(1, 5, ErrorMessage = "Please enter a valid state (1-5)")]
        public int State { get; set; }
        [Required]
        public string Description { get; set; }
        public DateTime DateGenerated { get; set; } 
    }
}
