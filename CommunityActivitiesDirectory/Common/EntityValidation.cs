namespace CommunityActivitiesDirectory.Common
{
    public static class EntityValidation
    {
        /* Activity */
        public const int ActivityTitleMaxLength = 100;
        public const int ActivityTitleMinLength = 3;
        public const int ActivityDescriptionMaxLength = 1000;
        public const int ActivityDescriptionMinLength = 1;
        public const int ActivityLocationMaxLength = 200;
        public const int ActivityLocationMinLength = 2;
        public const int ActivityOrganizerMaxLength = 200;
        public const int ActivityOrganizerMinLength = 2;
        public const int ActivityMinParticipants = 1;
        public const int ActivityMaxParticipants = 1000;

        /* Category */
        public const int CategoryNameMaxLength = 100;
        public const int CategoryNameMinLength = 2;

        /* Venue */
        public const int VenueNameMaxLength = 150;
        public const int VenueNameMinLength = 2;
        public const int VenueAddressMaxLength = 250;
        public const int VenueAddressMinLength = 2;
        public const int VenueCityMaxLength = 100;
        public const int VenueCityMinLength = 2;
    }
}