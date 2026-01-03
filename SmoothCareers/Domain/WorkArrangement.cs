// WorkArrangement.cs
namespace SmoothCareers.Domain
{
    public class WorkArrangement : BaseDomainModel
    {
        public string Name { get; set; } = string.Empty;

        // 1 WorkArrangement -> many JobPosts
        public ICollection<JobPost> JobPosts { get; set; } = new List<JobPost>();
    }
}
