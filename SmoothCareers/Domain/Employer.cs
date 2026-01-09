using SmoothCareers.Domain;

namespace SmoothCareers.Domain
{

    public class Employer : BaseDomainModel
    {
        // Employer.cs
        public string Name { get; set; } = string.Empty;


        public string CompanyName { get; set; } = string.Empty;
            public string Industry { get; set; } = string.Empty;
            public string Location { get; set; } = string.Empty;
            public string? About { get; set; }

            // Employer (1) -> JobPost (many)
            public ICollection<JobPost> JobPosts { get; set; } = new List<JobPost>();
        }
    }
