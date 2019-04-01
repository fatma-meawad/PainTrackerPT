﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PainTrackerPT.Models.Followups
{
    public class Advice : BaseEntity
    {
        public Int64 AnswerId { get => AnswerId; set => AnswerId = value; }
        [Required]
        public String Description { get => Description; set => Description = value; }
        public DateTime DateGenerated { get => DateGenerated; set => DateGenerated = value; }
    }
}
