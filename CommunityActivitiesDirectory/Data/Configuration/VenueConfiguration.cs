using CommunityActivitiesDirectory.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CommunityActivitiesDirectory.Data.Configuration
{
    public class VenueConfiguration : IEntityTypeConfiguration<Venue>
    {
        public static readonly Venue[] Venues =
        {
            new Venue { Id = 1, Name = "City Park", Address = "123 Main St", City = "Springfield" },
            new Venue { Id = 2, Name = "Innovation Hub", Address = "456 Tech Ave", City = "Springfield" },
            new Venue { Id = 3, Name = "Old Town", Address = "789 Heritage Rd", City = "Springfield" },
            new Venue { Id = 4, Name = "Conference Room A", Address = "101 Business Blvd", City = "Springfield" },
            new Venue { Id = 5, Name = "Culinary Studio", Address = "202 Gourmet Ln", City = "Springfield" },
            new Venue { Id = 6, Name = "Game Hall", Address = "303 Leisure St", City = "Springfield" },
            new Venue { Id = 7, Name = "Riverside Trail", Address = "404 River Rd", City = "Springfield" },
            new Venue { Id = 8, Name = "Training Center", Address = "505 Skill St", City = "Springfield" },
            new Venue { Id = 9, Name = "Art Gallery", Address = "606 Culture Ave", City = "Springfield" },
            new Venue { Id = 10, Name = "Startup Hub", Address = "707 Entrepreneur Way", City = "Springfield" }
        };


        public void Configure(EntityTypeBuilder<Venue> builder)
        {
            throw new NotImplementedException();
        }
    }
}
