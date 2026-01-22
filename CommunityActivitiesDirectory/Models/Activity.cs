using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static CommunityActivitiesDirectory.Common.EntityValidation;
namespace CommunityActivitiesDirectory.Models
{
    public class Activity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(ActivityTitleMaxLength)]
        [MinLength(ActivityTitleMinLength)]
        public string Title { get; set; } = null!;

        [Required]
        [MaxLength(ActivityDescriptionMaxLength)]
        [MinLength(ActivityDescriptionMinLength)]
        public string Description { get; set; } = null!;

        [Required]
        [MaxLength(ActivityLocationMaxLength)]
        [MinLength(ActivityLocationMinLength)]
        public string Location { get; set; } = null!;
        public DateTime Date { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        [Required]
        [MaxLength(ActivityOrganizerMaxLength)]
        [MinLength(ActivityOrganizerMinLength)]
        public string Organizer { get; set; } = null!;
        public bool IsPublic { get; set; }

        [Range(ActivityMinParticipants, ActivityMaxParticipants)]
        public int MaxParticipants { get; set; }

        [ForeignKey(nameof(Category))]
        public int CategoryId { get; set; }
        public Category? Category { get; set; }

        [ForeignKey(nameof(Venue))]
        public int VenueId { get; set; }
        public Venue? Venue { get; set; }
    }
}