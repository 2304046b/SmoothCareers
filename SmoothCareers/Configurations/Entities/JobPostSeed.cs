using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmoothCareers.Data;
using SmoothCareers.Domain;

namespace SmoothCareers.Configurations.Entities
{
    public class JobPostSeed : IEntityTypeConfiguration<JobPost>
    {
        public void Configure(EntityTypeBuilder<JobPost> builder)
        {
            builder.HasData(
                new JobPost
                {
                    Id = 1,
                    EmployerId = 1,
                    JobCategoryId = 1,        // e.g. IT / Software
                    JobTypeId = 1,            // e.g. Full-Time
                    WorkArrangementId = 2,    // e.g. Hybrid
                    Title = "Junior Full-Stack Developer (.NET)",
                    Description = "Build CRUD features with ASP.NET Core MVC, EF Core, SQL Server. Work with Git branching and code reviews.",
                    Location = "Singapore (Tampines)",
                    Salary = 4200m,
                    DatePosted = new DateTime(2026, 1, 2)
                },
                new JobPost
                {
                    Id = 2,
                    EmployerId = 1,
                    JobCategoryId = 1,
                    JobTypeId = 2,            // e.g. Intern
                    WorkArrangementId = 3,    // e.g. Remote
                    Title = "RPA Developer (Intern) - UiPath",
                    Description = "Support automation workflows for Outlook/Excel and document processes. Basic regex and debugging is a plus.",
                    Location = "Singapore (Remote)",
                    Salary = 1200m,
                    DatePosted = new DateTime(2026, 1, 3)
                },
                new JobPost
                {
                    Id = 3,
                    EmployerId = 1,
                    JobCategoryId = 2,        // e.g. Data / AI
                    JobTypeId = 1,
                    WorkArrangementId = 2,
                    Title = "Data Analyst (Entry-Level)",
                    Description = "Clean and analyze datasets using Python (Pandas) and build visual insights. Basic SQL required.",
                    Location = "Singapore (Central)",
                    Salary = 3800m,
                    DatePosted = new DateTime(2026, 1, 3)
                },
                new JobPost
                {
                    Id = 4,
                    EmployerId = 1,
                    JobCategoryId = 3,        // e.g. Design
                    JobTypeId = 2,
                    WorkArrangementId = 2,
                    Title = "UI/UX Designer (Intern)",
                    Description = "Create wireframes, user flows, and prototypes in Figma. Assist with usability testing and design systems.",
                    Location = "Singapore (CBD)",
                    Salary = 1200m,
                    DatePosted = new DateTime(2026, 1, 4)
                },
                new JobPost
                {
                    Id = 5,
                    EmployerId = 1,
                    JobCategoryId = 4,        // e.g. IT Support / Infrastructure
                    JobTypeId = 1,
                    WorkArrangementId = 1,    // e.g. Onsite
                    Title = "IT Support Technician (Hospital)",
                    Description = "Provide onsite support: Windows troubleshooting, printer issues, domain join, OneDrive/Outlook setup.",
                    Location = "Singapore (Central)",
                    Salary = 2800m,
                    DatePosted = new DateTime(2026, 1, 4)
                },
                new JobPost
                {
                    Id = 6,
                    EmployerId = 1,
                    JobCategoryId = 1,
                    JobTypeId = 3,            // e.g. Contract
                    WorkArrangementId = 2,
                    Title = "Software QA Tester (Contract)",
                    Description = "Execute test cases, report defects, and validate fixes. Exposure to test automation is a plus.",
                    Location = "Singapore (East)",
                    Salary = 3200m,
                    DatePosted = new DateTime(2026, 1, 5)
                },
                new JobPost
                {
                    Id = 7,
                    EmployerId = 1,
                    JobCategoryId = 4,
                    JobTypeId = 1,
                    WorkArrangementId = 1,
                    Title = "Network Support Engineer (Entry-Level)",
                    Description = "Assist with networking tasks: IP config, connectivity troubleshooting, and basic device setup.",
                    Location = "Singapore (North)",
                    Salary = 3400m,
                    DatePosted = new DateTime(2026, 1, 5)
                },
                new JobPost
                {
                    Id = 8,
                    EmployerId = 1,
                    JobCategoryId = 1,
                    JobTypeId = 4,            // e.g. Part-Time
                    WorkArrangementId = 2,
                    Title = "Web Developer (Part-Time)",
                    Description = "Maintain site pages, fix UI bugs, and implement small features. HTML/CSS/JS and basic .NET helpful.",
                    Location = "Singapore (Hybrid)",
                    Salary = 2200m,
                    DatePosted = new DateTime(2026, 1, 6)
                },
                new JobPost
                {
                    Id = 9,
                    EmployerId = 1,
                    JobCategoryId = 2,
                    JobTypeId = 3,
                    WorkArrangementId = 3,
                    Title = "Junior ML Engineer (Contract)",
                    Description = "Support model training experiments, data preprocessing, and evaluation. Python required.",
                    Location = "Singapore (Remote)",
                    Salary = 4500m,
                    DatePosted = new DateTime(2026, 1, 6)
                },
                new JobPost
                {
                    Id = 10,
                    EmployerId = 1,
                    JobCategoryId = 1,
                    JobTypeId = 1,
                    WorkArrangementId = 2,
                    Title = "Product Associate (Tech)",
                    Description = "Support product planning, write user stories, coordinate with dev/design, and track feature delivery.",
                    Location = "Singapore (CBD)",
                    Salary = 3600m,
                    DatePosted = new DateTime(2026, 1, 7)
                }
            );
        }
    }
}
