﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PainTrackerPT.Models.Analytics.GFPatient
{
    public class Mood
    {
        [Key]
        public int Id { get; set; }

        [Column("Date")]
        public DateTime Date { get; set; }

        [Column("MoodType")]
        public int MoodType { get; set; }

        [Column("Duration")]
        public int Duration { get; set; }

        [ForeignKey("PainDiary")]
        public int PainDiaryID { get; set; }
    }
}