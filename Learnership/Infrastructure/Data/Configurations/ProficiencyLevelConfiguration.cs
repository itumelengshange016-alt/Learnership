using Learnership.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Learnership.Infrastructure.Data.Configurations
{
    public class ProficiencyLevelConfiguration : IEntityTypeConfiguration<ProficiencyLevel>
    {
        public void Configure(EntityTypeBuilder<ProficiencyLevel> builder)
        {
            builder.ToTable("ProficiencyLevel", "dbo");
            builder.HasKey(e => e.ProficiencyLevelId);
            builder.Property(e => e.RowVersion).IsRowVersion();
        }
    }
}
