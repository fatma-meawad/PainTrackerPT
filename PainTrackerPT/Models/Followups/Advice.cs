using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PainTrackerPT.Models.Followups
{
    public class Advice : BaseEntity
    {
        private Guid AnswerId { get => AnswerId; set => AnswerId = value; }
        [Required]
        private String Description { get => Description; set => Description = value; }
        private DateTime DateGenerated { get => DateGenerated; set => DateGenerated = value; }
    }
}
