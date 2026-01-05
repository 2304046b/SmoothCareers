using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmoothCareers.Data;
using SmoothCareers.Domain;

namespace SmoothCareers.Configurations.Entities
{
    public class EmployerSeed : IEntityTypeConfiguration<Employer>
    {
        public void Configure(EntityTypeBuilder<Employer> builder)
        {
            builder.HasData(
                new Employer
                {
                    Id = 1,
                    // adjust these fields to your Employer class
                    CompanyName = "SmoothCareers Demo Pte Ltd",
                    // If your Employer has required audit fields, set them too:
                    DateCreated = new DateTime(2026, 1, 1),
                    DateUpdated = new DateTime(2026, 1, 1),
                    CreatedBy = null,
                    UpdatedBy = null
                }
            );
        }
    }
}
