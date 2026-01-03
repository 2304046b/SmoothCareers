// JobType.cs
namespace SmoothCareers.Domain
{
    public class JobType : BaseDomainModel
    {
        public string Name { get; set; } = string.Empty;

        // 1 JobType -> many JobPosts
        public ICollection<JobPost> JobPosts { get; set; } = new List<JobPost>();
    }
}
