using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmoothCareers.Domain
{
    public class SavedJob
    {
        [Key]
        public int Id { get; set; }

        public int JobPostId { get; set; }

        [ForeignKey(nameof(JobPostId))]
        public JobPost? JobPost { get; set; }

        public string SavedByUserId { get; set; } = string.Empty;

        public DateTime DateSaved { get; set; } = DateTime.UtcNow;
    }
}
