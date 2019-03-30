using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PainTrackerPT.Models.Followups.ViewModels
{
    public class QuestionnaireViewModel
    {
        private Guid PatientId { get => PatientId; set => PatientId = value; }
        private Guid DoctorId { get => DoctorId; set => DoctorId = value; }
        private int State { get => State; set => State = value; }
        private String Description { get => Description; set => Description = value; }
        private DateTime DateGenerated { get => DateGenerated; set => DateGenerated = value; }
        private String Question { get => Question; set => Question = value; }
        private String Answer { get => Answer; set => Answer = value; }
        private String Advice { get => Advice; set => Advice = value; }
        private String Recommendation { get => Recommendation; set => Recommendation = value; }
        private String Media { get => Media; set => Media = value; }
    }
}
