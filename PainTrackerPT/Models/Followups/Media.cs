using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PainTrackerPT.Models.Followups
{
    public class Media : BaseEntity
    {
        public Guid RelatedID { get => RelatedID; set => RelatedID = value; }
        [Required]
        public String MediaUrl { get => MediaUrl; set => MediaUrl = value; }
    }
}
