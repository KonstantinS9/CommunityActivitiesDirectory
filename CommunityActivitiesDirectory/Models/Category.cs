using System.ComponentModel.DataAnnotations;
using static CommunityActivitiesDirectory.Common.EntityValidation;
namespace CommunityActivitiesDirectory.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(CategoryNameMaxLength)]
        [MinLength(CategoryNameMinLength)]
        public string Name { get; set; } = null!;

        public bool IsActive { get; set; }

        public ICollection<Activity> Activities { get; set; } = new List<Activity>();
    }
}
