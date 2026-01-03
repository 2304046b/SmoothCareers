// RoleSeed.cs
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SmoothCareers.Configurations.Entities
{
    public class RoleSeed : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole
                {
                    Id = "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                    Name = "Administrator",
                    NormalizedName = "ADMINISTRATOR"
                },
                new IdentityRole
                {
                    Id = "cd2bcf0c-20db-474f-8407-5a6b159518bc",
                    Name = "Employer",
                    NormalizedName = "EMPLOYER"
                },
                new IdentityRole
                {
                    Id = "dd2bcf0c-20db-474f-8407-5a6b159518bd",
                    Name = "JobSeeker",
                    NormalizedName = "JOBSEEKER"
                }
            );
        }
    }
}
