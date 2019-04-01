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
        public Guid FollowUpId { get => FollowUpId; set => FollowUpId = value; }
        public String Description { get => Description; set => Description = value; }
        public DateTime DateGenerated { get => DateGenerated; set => DateGenerated = value; }

        public virtual FollowUp FollowUp { get; set; }
    }
}
