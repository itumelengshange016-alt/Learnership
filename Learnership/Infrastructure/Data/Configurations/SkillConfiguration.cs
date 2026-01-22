using Learnership.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Learnership.Infrastructure.Data.Configurations
{
    public class SkillConfiguration : IEntityTypeConfiguration<Skill>
    {
        public void Configure(EntityTypeBuilder<Skill> builder)
        {
            builder.ToTable("Skill", "dbo");
            builder.HasKey(e => e.SkillId);
            builder.Property(e => e.RowVersion).IsRowVersion();
            builder.Property(e => e.SkillName).IsRequired();
            
            builder.HasOne(d => d.ProficiencyLevel)
                   .WithMany(p => p.Skills)
                   .HasForeignKey(d => d.ProficiencyLevelId);
        }
    }
}
