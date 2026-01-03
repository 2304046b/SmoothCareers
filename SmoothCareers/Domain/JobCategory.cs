// JobCategory.cs
namespace SmoothCareers.Domain
{
    public class JobCategory : BaseDomainModel
    {
        public string Name { get; set; } = string.Empty;

        // 1 JobCategory -> many JobPosts
        public ICollection<JobPost> JobPosts { get; set; } = new List<JobPost>();
    }
}
