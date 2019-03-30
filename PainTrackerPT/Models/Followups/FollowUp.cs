using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PainTrackerPT.Models.Followups
{
    public class FollowUp : BaseEntity
    {
        public Guid PatientId { get => PatientId; set => PatientId = value; }
        public Guid DoctorID { get => DoctorID; set => DoctorID = value; }
        [Required]
        public int State { get => State; set => State = value; }
        [Required]
        public string Description { get => Description; set => Description = value; }
        public DateTime DateGenerated { get => DateGenerated; set => DateGenerated = value; } 
    }
}
