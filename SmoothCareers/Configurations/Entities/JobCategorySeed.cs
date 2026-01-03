

// JobCategorySeed.cs
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmoothCareers.Domain;

namespace SmoothCareers.Configurations.Entities
{
    public class JobCategorySeed : IEntityTypeConfiguration<JobCategory>
    {
        public void Configure(EntityTypeBuilder<JobCategory> builder)
        {
            builder.HasData(
                new JobCategory
                {
                    Id = 1,
                    Name = "Software Engineering",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new JobCategory
                {
                    Id = 2,
                    Name = "Data & Analytics",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new JobCategory
                {
                    Id = 3,
                    Name = "Cybersecurity",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new JobCategory
                {
                    Id = 4,
                    Name = "UI/UX Design",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new JobCategory
                {
                    Id = 5,
                    Name = "IT Support",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new JobCategory
                {
                    Id = 6,
                    Name = "Business & Operations",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }
            );
        }
    }
}
