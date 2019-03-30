﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PainTrackerPT.Models.Followups
{
    public class Answer : BaseEntity
    {
        private String Description { get => Description; set => Description = value; }
        [Required]
        private DateTime DateGenerated { get => DateGenerated; set => DateGenerated = value; }
    }
}