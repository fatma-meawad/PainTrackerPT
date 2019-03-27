using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PainTrackerPT.Models.Followups
{
    public class FollowUp : IFollowUp
    {
        public Guid FollowUpId { get; set; }
        public IFollowUpState State { get; set; }
        public List<IAdvice> Advice { get; set; }
        public string Description { get; set; }
        public DateTime DateGenerated { get; set; }
    }
}
