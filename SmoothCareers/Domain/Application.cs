using SmoothCareers.Domain;

namespace SmoothCareers.Domain
{
   

    public class Application : BaseDomainModel
    {
        // FK -> JobPost (Application is sent to a JobPost)
        public int JobPostId { get; set; }
        public JobPost? JobPost { get; set; }

        // FK -> JobSeeker (JobSeeker makes Application)
        public int JobSeekerId { get; set; }
        public JobSeeker? JobSeeker { get; set; }

        // Employer reviews via Application -> JobPost -> Employer (no extra FK needed)
        public string Status { get; set; } = "Pending";

        // Can use DateCreated instead, but keeping ERD-style field
        public DateTime DateApplied { get; set; }
    }
}

