using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PainTrackerPT.Models.Followups
{
    public class Advice : IAdvice
    {
        public Guid AdviceId { get; set; }
        public String Description { get; set; }
        public DateTime DateGenerated { get; set; }
    }
}
