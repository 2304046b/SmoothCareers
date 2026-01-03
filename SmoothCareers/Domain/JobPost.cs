using SmoothCareers.Domain;

// JobPost.cs (UPDATED)
namespace SmoothCareers.Domain
{
    public class JobPost : BaseDomainModel
    {
        // FK -> Employer (Employer makes JobPost)
        public int EmployerId { get; set; }
        public Employer? Employer { get; set; }

        // FK -> JobCategory (like Vehicle -> Make)
        public int JobCategoryId { get; set; }
        public JobCategory? JobCategory { get; set; }

        // FK -> JobType (like Vehicle -> Model)
        public int JobTypeId { get; set; }
        public JobType? JobType { get; set; }

        // FK -> WorkArrangement (like Vehicle -> Colour)
        public int WorkArrangementId { get; set; }
        public WorkArrangement? WorkArrangement { get; set; }

        public string Title { get; set; } = string.Empty;
        public string? Description { get; set; }

        // Keep as string OR switch to Location entity later
        public string Location { get; set; } = string.Empty;

        // Money
        public decimal? Salary { get; set; }

        public DateTime DatePosted { get; set; }

        // JobPost (1) -> Application (many)
        public ICollection<Application> Applications { get; set; } = new List<Application>();
    }
}
