using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PainTrackerPT.Models.Followups
{
    public class Answer : BaseEntity
    {
        public Int64 QuestionId { get; set ; }
        public String Description { get; set; }
        [Required]
        public DateTime DateGenerated { get; set; }
    }
}
