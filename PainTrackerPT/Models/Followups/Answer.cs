using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PainTrackerPT.Models.Followups
{
    public class Answer
    {
        public Guid AnswerId { get; set; }
        public Advice Advice { get; set; }
        public Recommendation Recommendation { get; set; }
        public string Description { get; set; }
        public List<AbstractMedia> AttachmentList { get; set; }
        public DateTime DateGenerated { get; set; }
    }
}
