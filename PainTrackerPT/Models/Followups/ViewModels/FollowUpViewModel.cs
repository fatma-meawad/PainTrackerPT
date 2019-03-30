using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PainTrackerPT.Models.Followups.ViewModels
{
    public class FollowUpViewModel
    {
        public Guid PatientId { get => PatientId; set => PatientId = value; }
        public Guid DoctorId { get => DoctorId; set => DoctorId = value; }
        public int State { get => State; set => State = value; }
        public String Description { get => Description; set => Description = value; }
        public DateTime DateGenerated { get => DateGenerated; set => DateGenerated = value; }
    }
}
