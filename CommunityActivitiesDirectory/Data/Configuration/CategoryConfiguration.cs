using CommunityActivitiesDirectory.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CommunityActivitiesDirectory.Data.Configuration
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public static readonly Category[] Categories =
        {
            new Category { Id = 1, Name = "Sports & Fitness", IsActive = true },
            new Category { Id = 2, Name = "Technology", IsActive = true },
            new Category { Id = 3, Name = "Arts & Culture", IsActive = true },
            new Category { Id = 4, Name = "Business & Education", IsActive = true },
            new Category { Id = 5, Name = "Food & Lifestyle", IsActive = true }
        };


        public void Configure(EntityTypeBuilder<Category> entity)
        {
            entity
                .HasData(Categories);
        }
    }
}
