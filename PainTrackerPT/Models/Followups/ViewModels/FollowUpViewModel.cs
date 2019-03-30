using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PainTrackerPT.Models.Followups.ViewModels
{
    public class FollowUpViewModel
    {
        private Guid PatientId { get => PatientId; set => PatientId = value; }
        private Guid DoctorId { get => DoctorId; set => DoctorId = value; }
        private int State { get => State; set => State = value; }
        private String Description { get => Description; set => Description = value; }
        private DateTime DateGenerated { get => DateGenerated; set => DateGenerated = value; }
    }
}
