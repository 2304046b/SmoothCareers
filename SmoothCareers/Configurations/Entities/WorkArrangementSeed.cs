// WorkArrangementSeed.cs
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmoothCareers.Domain;

namespace SmoothCareers.Configurations.Entities
{
    public class WorkArrangementSeed : IEntityTypeConfiguration<WorkArrangement>
    {
        public void Configure(EntityTypeBuilder<WorkArrangement> builder)
        {
            builder.HasData(
                new WorkArrangement
                {
                    Id = 1,
                    Name = "Onsite",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new WorkArrangement
                {
                    Id = 2,
                    Name = "Hybrid",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new WorkArrangement
                {
                    Id = 3,
                    Name = "Remote",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }
            );
        }
    }
}
