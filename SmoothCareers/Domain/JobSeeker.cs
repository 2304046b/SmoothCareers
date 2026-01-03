using SmoothCareers.Domain;

namespace SmoothCareers.Domain
{
 
    public class JobSeeker : BaseDomainModel
    {
        public string FullName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;

        public string? Skills { get; set; }
        public string? Resume { get; set; }

        // JobSeeker (1) -> Application (many)
        public ICollection<Application> Applications { get; set; } = new List<Application>();
    }
}
