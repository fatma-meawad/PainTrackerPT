using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PainTrackerPT.Data.Followups.DatabaseConfiguration;
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
        public PainTrackerPTContext()
        {

        }

        public PainTrackerPTContext (DbContextOptions<PainTrackerPTContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //To be edited to your own database
                optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Initial Catalog=PainTrackerPTContext-b0b2ee36-cc0a-4b14-ac34-368168252e49;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            new FollowUpMap(modelBuilder.Entity<FollowUp>());
            new QuestionMap(modelBuilder.Entity<Question>());
        }

        public DbSet<PainTrackerPT.Models.Analytics.AnalyticsLog> AnalyticsLog { get; set; }

        public DbSet<PainTrackerPT.Models.Doctors.DoctorsLog> DoctorsLog { get; set; }

        public DbSet<PainTrackerPT.Models.Events.EventsLog> EventsLog { get; set; }

        public DbSet<PainTrackerPT.Models.Followups.FollowupsLog> FollowupsLog { get; set; }

        public DbSet<PainTrackerPT.Models.Medicine.MedicineLog> MedicineLog { get; set; }

        public DbSet<PainTrackerPT.Models.PainDiary.PainDiaryLog> PainDiaryLog { get; set; }

        public DbSet<PainTrackerPT.Models.Followups.FollowUp> FollowUp { get; set; }

        public DbSet<PainTrackerPT.Models.Followups.Question> Question { get; set; }

        public DbSet<PainTrackerPT.Models.Followups.Answer> Answer { get; set; }

        public DbSet<PainTrackerPT.Models.Followups.Advice> Advice { get; set; }

        public DbSet<PainTrackerPT.Models.Followups.Recommendation> Recommendation { get; set; }

        public DbSet<PainTrackerPT.Models.Followups.Media> Media { get; set; }


    }
}
