// UserSeed.cs
using SmoothCareers.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SmoothCareers.Configurations.Entities
{
    public class UserSeed : IEntityTypeConfiguration<SmoothCareersUser>
    {
        public void Configure(EntityTypeBuilder<SmoothCareersUser> builder)
        {
            var hasher = new PasswordHasher<SmoothCareersUser>();

            builder.HasData(
                new SmoothCareersUser
                {
                    Id = "3781efa7-66dc-47f0-860f-e506d04102e4",
                    Email = "admin@smoothcareers.com",
                    NormalizedEmail = "ADMIN@SMOOTHCAREERS.COM",
                    UserName = "admin@smoothcareers.com",
                    NormalizedUserName = "ADMIN@SMOOTHCAREERS.COM",
                    PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                    EmailConfirmed = true
                },
                new SmoothCareersUser
                {
                    Id = "b1a2c3d4-e5f6-47a8-9b01-112233445566",
                    Email = "employer@smoothcareers.com",
                    NormalizedEmail = "EMPLOYER@SMOOTHCAREERS.COM",
                    UserName = "employer@smoothcareers.com",
                    NormalizedUserName = "EMPLOYER@SMOOTHCAREERS.COM",
                    PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                    EmailConfirmed = true
                },
                new SmoothCareersUser
                {
                    Id = "c2b3a4d5-e6f7-48b9-8c02-667788990011",
                    Email = "jobseeker@smoothcareers.com",
                    NormalizedEmail = "JOBSEEKER@SMOOTHCAREERS.COM",
                    UserName = "jobseeker@smoothcareers.com",
                    NormalizedUserName = "JOBSEEKER@SMOOTHCAREERS.COM",
                    PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                    EmailConfirmed = true
                }
            );
        }
    }
}
