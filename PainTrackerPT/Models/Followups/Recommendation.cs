using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PainTrackerPT.Models.Followups
{
    public class Recommendation
    {
        public Guid RecommendationId { get; set; }
        public string Description { get; set; } 
        public DateTime DateGenerated { get; set; }
    }
}
