using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PainTrackerPT.Models.Followups
{
    public class FollowUp : BaseEntity
    {
        public Int64 PatientId { get; set; }
        public Int64 DoctorId { get; set; }
        [Range(1, 5)] public int State { get; set; } = 1;
        [Required]
        public string Description { get; set; }
        public DateTime DateGenerated { get; set; }

    }
}
