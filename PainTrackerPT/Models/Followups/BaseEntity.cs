using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PainTrackerPT.Models.Followups
{
    public class BaseEntity
    {
        [Key]
        public Guid id { get => id; set => id = value; }
    }
}
