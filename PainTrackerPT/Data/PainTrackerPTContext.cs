﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PainTrackerPT.Models.Analytics;
using PainTrackerPT.Models.Doctors;
using PainTrackerPT.Models.Events;
using PainTrackerPT.Models.Followups;
using PainTrackerPT.Models.Medicine;
using PainTrackerPT.Models.PainDiary;

namespace PainTrackerPT.Models
{
    public class PainTrackerPTContext : DbContext
    {
        public PainTrackerPTContext (DbContextOptions<PainTrackerPTContext> options)
            : base(options)
        {
        }

        //Ginyu Force Analytics
        public DbSet<PainTrackerPT.Models.Analytics.GFPatient.PainDiary> PainDiary { get; set; }
        public DbSet<PainTrackerPT.Models.Analytics.GFPatient.Interference> Interference { get; set; }
        public DbSet<PainTrackerPT.Models.Analytics.GFPatient.Mood> Mood { get; set; }
        public DbSet<PainTrackerPT.Models.Analytics.GFPatient.PainIntensity> PainIntensity { get; set; }
        public DbSet<PainTrackerPT.Models.Analytics.GFPatient.Sleep> Sleep { get; set; }
        public DbSet<PainTrackerPT.Models.Analytics.GFPatient.MedicineIntake> MedicineIntake { get; set; }

        public DbSet<PainTrackerPT.Models.Analytics.AnalyticsLog> AnalyticsLog { get; set; }

        public DbSet<PainTrackerPT.Models.Doctors.DoctorsLog> DoctorsLog { get; set; }

        public DbSet<PainTrackerPT.Models.Events.EventsLog> EventsLog { get; set; }

        public DbSet<PainTrackerPT.Models.Followups.FollowupsLog> FollowupsLog { get; set; }

        public DbSet<PainTrackerPT.Models.Medicine.MedicineLog> MedicineLog { get; set; }

        public DbSet<PainTrackerPT.Models.PainDiary.PainDiaryLog> PainDiaryLog { get; set; }
    }
}
