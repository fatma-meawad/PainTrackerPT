using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PainTrackerPT.Models.Followups;

namespace PainTrackerPT.Data.Followups.DatabaseConfiguration
{
    public class FollowUpMap
    {
        public FollowUpMap(EntityTypeBuilder<FollowUp> entityBuilder)
        {
            entityBuilder.HasKey(t => t.Id);
            entityBuilder.Property(t => t.DoctorId).IsRequired();
            entityBuilder.Property(t => t.PatientId).IsRequired();
            entityBuilder.Property(t => t.State).IsRequired();
            entityBuilder.Property(t => t.Description).IsRequired();
            entityBuilder.Property(t => t.DateGenerated).IsRequired();
        }
    }
}
