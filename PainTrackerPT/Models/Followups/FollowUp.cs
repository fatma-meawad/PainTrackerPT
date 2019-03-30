using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PainTrackerPT.Models.Followups
{
    public class FollowUp : BaseEntity
    {
        private Guid PatientId { get => PatientId; set => PatientId = value; }
        private Guid DoctorID { get => DoctorID; set => DoctorID = value; }
        [Required]
        private int State { get => State; set => State = value; }
        [Required]
        private string Description { get => Description; set => Description = value; }
        private DateTime DateGenerated { get => DateGenerated; set => DateGenerated = value; } 
    }
}
