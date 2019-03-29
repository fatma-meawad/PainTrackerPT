using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PainTrackerPT.Models.Followups
{
    public class FollowUp 
    {
        public Guid FollowUpId { get; set; }
        public int State { get; set; }
        public List<Advice> Advice { get; set; }
        public string Description { get; set; }
        public DateTime DateGenerated { get; set; }
        public List<Question> Questions { get; set; }
    }
}
