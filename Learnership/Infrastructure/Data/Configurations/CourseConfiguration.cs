using Learnership.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Learnership.Infrastructure.Data.Configurations
{
    public class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.ToTable("Course", "dbo");
            builder.HasKey(e => e.CourseId);
            builder.Property(e => e.RowVersion).IsRowVersion();
            builder.Property(e => e.CoursePrice).HasPrecision(18, 2);
        }
    }
}
