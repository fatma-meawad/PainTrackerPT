using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// TODO: Implement this
namespace PainTrackerPT.Models.Followups
{
    public abstract class AbstractMedia{
        public Guid MediaId{get;set;}
        public String MediaUrl{get;set;}
    }
}
