using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PainTrackerPT.Models.Followups
{
    public class Media : BaseEntity
    {
        private Guid AnswerId { get => AnswerId; set => AnswerId = value; }
        [Required]
        private String MediaUrl { get => MediaUrl; set => MediaUrl = value; }
    }
}
