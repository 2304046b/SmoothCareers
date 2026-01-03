using System.Reflection.Emit;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SmoothCareers.Configurations.Entities;
using SmoothCareers.Data;

namespace SmoothCareers.Data
{
    public class SmoothCareersContext(DbContextOptions<SmoothCareersContext> options) : IdentityDbContext<SmoothCareersUser>(options)
    {
        public DbSet<SmoothCareers.Domain.JobPost> JobPost { get; set; } = default!;
        public DbSet<SmoothCareers.Domain.JobCategory> JobCategory { get; set; } = default!;
        public DbSet<SmoothCareers.Domain.JobType> JobType { get; set; } = default!;
        public DbSet<SmoothCareers.Domain.WorkArrangement> WorkArrangement { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new JobCategorySeed());
            builder.ApplyConfiguration(new JobTypeSeed());
            builder.ApplyConfiguration(new WorkArrangementSeed());
            builder.ApplyConfiguration(new RoleSeed());
            builder.ApplyConfiguration(new UserSeed());
            builder.ApplyConfiguration(new UserRoleSeed());


        }
    }
}
