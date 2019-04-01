using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PainTrackerPT.Models.Followups
{
    public class Advice : BaseEntity
    {
        public Int64 AnswerId { get; set; }
        [Required]
        public String Description { get; set; }
        public DateTime DateGenerated { get; set; }
    }
}
