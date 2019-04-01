using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.AccessControl;
using System.Threading.Tasks;

namespace PainTrackerPT.Models.Followups
{
    public class Question : BaseEntity
    {
        public Guid FollowUpId { get; set; }
        public String Description { get; set; }
        public DateTime DateGenerated { get; set; }

        public virtual FollowUp FollowUp { get; set; }
    }
}
