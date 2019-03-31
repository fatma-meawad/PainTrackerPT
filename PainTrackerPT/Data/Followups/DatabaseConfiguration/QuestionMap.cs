using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PainTrackerPT.Models.Followups;

namespace PainTrackerPT.Data.Followups.DatabaseConfiguration
{
    public class QuestionMap
    {
        public QuestionMap(EntityTypeBuilder<Question> entityBuilder)
        {
            entityBuilder.HasKey(t => t.Id);
            entityBuilder.Property(t => t.Description).IsRequired();
            entityBuilder.Property(t => t.DateGenerated).IsRequired();
            entityBuilder.HasOne(e => e.FollowUp).WithMany(e => e.Questions).HasForeignKey(e => e.FollowUpId);
        }
    }
}
