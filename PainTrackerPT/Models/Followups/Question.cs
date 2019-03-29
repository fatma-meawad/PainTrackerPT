using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Threading.Tasks;

namespace PainTrackerPT.Models.Followups
{
    public class Question
    {
        public Guid QuestionId { get; set; }
        public Answer Answer { get; set; }
        public string Description { get; set; }
        public DateTime DateGenerated { get; set; }
    }
}
