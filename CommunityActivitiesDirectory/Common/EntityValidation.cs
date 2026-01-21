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
    }
}