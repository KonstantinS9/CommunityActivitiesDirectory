using System.ComponentModel.DataAnnotations;
using static CommunityActivitiesDirectory.Common.EntityValidation;  
namespace CommunityActivitiesDirectory.Models
{
    public class Venue
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(VenueNameMaxLength)]
        [MinLength(VenueNameMinLength)]
        public string Name { get; set; } = null!;

        [Required]
        [MaxLength(VenueAddressMaxLength)]
        [MinLength(VenueAddressMinLength)]
        public string Address { get; set; } = null!;

        [Required]
        [MaxLength(VenueCityMaxLength)]
        [MinLength(VenueCityMinLength)]
        public string City { get; set; } = null!;
    }
}