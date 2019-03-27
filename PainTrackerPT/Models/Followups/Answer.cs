using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PainTrackerPT.Models.Followups
{
    public class Answer : IAnswer
    {
        public Guid AnswerId { get; set; }
        public IAdvice Advice { get; set; }
        public IRecommendation Recommendation { get; set; }
        public string Description { get; set; }
        public List<IMedia> AttachmentList { get; set; }
        public DateTime DateGenerated { get; set; }
    }
}
