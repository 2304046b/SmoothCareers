// UserRoleSeed.cs
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SmoothCareers.Configurations.Entities
{
    public class UserRoleSeed : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                // Admin -> Administrator
                new IdentityUserRole<string>
                {
                    RoleId = "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                    UserId = "3781efa7-66dc-47f0-860f-e506d04102e4"
                },

                // Employer demo -> Employer
                new IdentityUserRole<string>
                {
                    RoleId = "cd2bcf0c-20db-474f-8407-5a6b159518bc",
                    UserId = "b1a2c3d4-e5f6-47a8-9b01-112233445566"
                },

                // JobSeeker demo -> JobSeeker
                new IdentityUserRole<string>
                {
                    RoleId = "dd2bcf0c-20db-474f-8407-5a6b159518bd",
                    UserId = "c2b3a4d5-e6f7-48b9-8c02-667788990011"
                }
            );
        }
    }
}
