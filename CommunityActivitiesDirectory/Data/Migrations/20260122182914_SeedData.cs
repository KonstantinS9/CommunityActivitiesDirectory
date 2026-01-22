using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CommunityActivitiesDirectory.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "StartTime",
                table: "Activities",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(TimeSpan),
                oldType: "time");

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndTime",
                table: "Activities",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(TimeSpan),
                oldType: "time");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "IsActive", "Name" },
                values: new object[,]
                {
                    { 1, true, "Sports & Fitness" },
                    { 2, true, "Technology" },
                    { 3, true, "Arts & Culture" },
                    { 4, true, "Business & Education" },
                    { 5, true, "Food & Lifestyle" }
                });

            migrationBuilder.InsertData(
                table: "Venues",
                columns: new[] { "Id", "Address", "City", "Name" },
                values: new object[,]
                {
                    { 1, "123 Main St", "Springfield", "City Park" },
                    { 2, "456 Tech Ave", "Springfield", "Innovation Hub" },
                    { 3, "789 Heritage Rd", "Springfield", "Old Town" },
                    { 4, "101 Business Blvd", "Springfield", "Conference Room A" },
                    { 5, "202 Gourmet Ln", "Springfield", "Culinary Studio" },
                    { 6, "303 Leisure St", "Springfield", "Game Hall" },
                    { 7, "404 River Rd", "Springfield", "Riverside Trail" },
                    { 8, "505 Skill St", "Springfield", "Training Center" },
                    { 9, "606 Culture Ave", "Springfield", "Art Gallery" },
                    { 10, "707 Entrepreneur Way", "Springfield", "Startup Hub" }
                });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "CategoryId", "Date", "Description", "EndTime", "IsPublic", "Location", "MaxParticipants", "Organizer", "StartTime", "Title", "VenueId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2026, 3, 10, 0, 0, 0, 0, DateTimeKind.Local), "A relaxing yoga session suitable for all levels to start the day energized.", new DateTime(2026, 3, 10, 9, 30, 0, 0, DateTimeKind.Local), true, "City Park", 250, "Healthy Living Club", new DateTime(2026, 3, 10, 8, 0, 0, 0, DateTimeKind.Local), "Morning Yoga Session", 1 },
                    { 2, 2, new DateTime(2026, 3, 12, 0, 0, 0, 0, DateTimeKind.Local), "An evening event for developers and tech enthusiasts to connect and share ideas.", new DateTime(2026, 3, 12, 20, 30, 0, 0, DateTimeKind.Local), true, "Innovation Hub", 400, "Tech Community", new DateTime(2026, 3, 12, 18, 0, 0, 0, DateTimeKind.Local), "Tech Networking Evening", 2 },
                    { 3, 3, new DateTime(2026, 3, 15, 0, 0, 0, 0, DateTimeKind.Local), "Guided photography walk through the historic district with a professional photographer.", new DateTime(2026, 3, 15, 12, 30, 0, 0, DateTimeKind.Local), true, "Old Town", 220, "Photo Lovers Group", new DateTime(2026, 3, 15, 10, 0, 0, 0, DateTimeKind.Local), "Photography Walk", 3 },
                    { 4, 4, new DateTime(2026, 3, 18, 0, 0, 0, 0, DateTimeKind.Local), "Hands-on workshop focused on building sustainable business strategies.", new DateTime(2026, 3, 18, 13, 0, 0, 0, DateTimeKind.Local), false, "Conference Room A", 300, "Business Leaders Network", new DateTime(2026, 3, 18, 9, 0, 0, 0, DateTimeKind.Local), "Business Strategy Workshop", 4 },
                    { 5, 5, new DateTime(2026, 3, 20, 0, 0, 0, 0, DateTimeKind.Local), "Learn to cook a three-course meal with a professional chef.", new DateTime(2026, 3, 20, 20, 0, 0, 0, DateTimeKind.Local), true, "Culinary Studio", 200, "Food & Fun", new DateTime(2026, 3, 20, 17, 0, 0, 0, DateTimeKind.Local), "Cooking Masterclass", 5 },
                    { 6, 3, new DateTime(2026, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), "Monthly discussion of contemporary fiction over coffee.", new DateTime(2026, 3, 22, 17, 30, 0, 0, DateTimeKind.Local), true, "Community Library", 230, "Readers Circle", new DateTime(2026, 3, 22, 16, 0, 0, 0, DateTimeKind.Local), "Book Club Meetup", 6 },
                    { 7, 1, new DateTime(2026, 3, 23, 0, 0, 0, 0, DateTimeKind.Local), "Group run followed by stretching and refreshments.", new DateTime(2026, 3, 23, 20, 0, 0, 0, DateTimeKind.Local), true, "Riverside Trail", 450, "City Runners", new DateTime(2026, 3, 23, 18, 30, 0, 0, DateTimeKind.Local), "Evening Run Club", 7 },
                    { 8, 4, new DateTime(2026, 3, 25, 0, 0, 0, 0, DateTimeKind.Local), "Introduction to digital marketing fundamentals for small businesses.", new DateTime(2026, 3, 25, 14, 0, 0, 0, DateTimeKind.Local), false, "Training Center", 350, "Marketing Pros", new DateTime(2026, 3, 25, 10, 0, 0, 0, DateTimeKind.Local), "Marketing Basics Seminar", 8 },
                    { 9, 3, new DateTime(2026, 3, 27, 0, 0, 0, 0, DateTimeKind.Local), "Guided tour of the latest modern art exhibition.", new DateTime(2026, 3, 27, 16, 30, 0, 0, DateTimeKind.Local), true, "Art Gallery", 280, "Arts Association", new DateTime(2026, 3, 27, 15, 0, 0, 0, DateTimeKind.Local), "Art Exhibition Tour", 9 },
                    { 10, 2, new DateTime(2026, 3, 28, 0, 0, 0, 0, DateTimeKind.Local), "Local startups pitch ideas to mentors and investors.", new DateTime(2026, 3, 28, 21, 0, 0, 0, DateTimeKind.Local), true, "Startup Hub", 500, "Entrepreneurs Network", new DateTime(2026, 3, 28, 18, 0, 0, 0, DateTimeKind.Local), "Startup Pitch Night", 10 },
                    { 11, 1, new DateTime(2026, 4, 2, 0, 0, 0, 0, DateTimeKind.Local), "A scenic hiking trip suitable for beginners.", new DateTime(2026, 4, 2, 12, 0, 0, 0, DateTimeKind.Local), true, "Green Hills", 300, "Outdoor Adventures", new DateTime(2026, 4, 2, 7, 30, 0, 0, DateTimeKind.Local), "Weekend Hiking Trip", 1 },
                    { 12, 2, new DateTime(2026, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), "Practical workshop on user-centered design principles.", new DateTime(2026, 4, 4, 13, 0, 0, 0, DateTimeKind.Local), false, "Design Lab", 260, "Creative Studio", new DateTime(2026, 4, 4, 9, 0, 0, 0, DateTimeKind.Local), "UI/UX Design Workshop", 2 },
                    { 13, 1, new DateTime(2026, 4, 6, 0, 0, 0, 0, DateTimeKind.Local), "Volunteer event focused on cleaning public spaces.", new DateTime(2026, 4, 6, 12, 0, 0, 0, DateTimeKind.Local), true, "Downtown Area", 500, "City Volunteers", new DateTime(2026, 4, 6, 8, 0, 0, 0, DateTimeKind.Local), "Community Cleanup Day", 3 },
                    { 14, 5, new DateTime(2026, 4, 8, 0, 0, 0, 0, DateTimeKind.Local), "Explore local wines with expert guidance.", new DateTime(2026, 4, 8, 20, 0, 0, 0, DateTimeKind.Local), true, "Wine Cellar", 220, "Gourmet Society", new DateTime(2026, 4, 8, 18, 0, 0, 0, DateTimeKind.Local), "Wine Tasting Evening", 4 },
                    { 15, 4, new DateTime(2026, 4, 10, 0, 0, 0, 0, DateTimeKind.Local), "Improve confidence and speaking skills in a supportive environment.", new DateTime(2026, 4, 10, 18, 0, 0, 0, DateTimeKind.Local), false, "Meeting Room B", 240, "Toastmasters Group", new DateTime(2026, 4, 10, 16, 0, 0, 0, DateTimeKind.Local), "Public Speaking Practice", 5 },
                    { 16, 3, new DateTime(2026, 4, 12, 0, 0, 0, 0, DateTimeKind.Local), "Friendly chess competition for intermediate players.", new DateTime(2026, 4, 12, 16, 0, 0, 0, DateTimeKind.Local), true, "Game Hall", 320, "Chess Club", new DateTime(2026, 4, 12, 11, 0, 0, 0, DateTimeKind.Local), "Chess Tournament", 6 },
                    { 17, 2, new DateTime(2026, 4, 14, 0, 0, 0, 0, DateTimeKind.Local), "Discussion on current trends and future of artificial intelligence.", new DateTime(2026, 4, 14, 19, 0, 0, 0, DateTimeKind.Local), true, "Auditorium", 500, "Tech Talks", new DateTime(2026, 4, 14, 17, 0, 0, 0, DateTimeKind.Local), "AI Trends Talk", 7 },
                    { 18, 3, new DateTime(2026, 4, 16, 0, 0, 0, 0, DateTimeKind.Local), "Hands-on introduction to pottery and clay shaping.", new DateTime(2026, 4, 16, 17, 0, 0, 0, DateTimeKind.Local), true, "Art Studio", 210, "Creative Hands", new DateTime(2026, 4, 16, 14, 0, 0, 0, DateTimeKind.Local), "Pottery Basics", 8 },
                    { 19, 4, new DateTime(2026, 4, 18, 0, 0, 0, 0, DateTimeKind.Local), "Learn the basics of budgeting, saving, and investing.", new DateTime(2026, 4, 18, 12, 30, 0, 0, DateTimeKind.Local), false, "Finance Center", 380, "Finance Advisors", new DateTime(2026, 4, 18, 10, 0, 0, 0, DateTimeKind.Local), "Financial Planning 101", 9 },
                    { 20, 1, new DateTime(2026, 4, 20, 0, 0, 0, 0, DateTimeKind.Local), "Outdoor guided meditation session during sunset.", new DateTime(2026, 4, 20, 19, 30, 0, 0, DateTimeKind.Local), true, "Lakeside Park", 270, "Mindfulness Group", new DateTime(2026, 4, 20, 18, 30, 0, 0, DateTimeKind.Local), "Sunset Meditation", 10 },
                    { 21, 3, new DateTime(2026, 4, 22, 0, 0, 0, 0, DateTimeKind.Local), "Practice foreign languages with native speakers.", new DateTime(2026, 4, 22, 20, 0, 0, 0, DateTimeKind.Local), true, "Cultural Center", 420, "Global Friends", new DateTime(2026, 4, 22, 18, 0, 0, 0, DateTimeKind.Local), "Language Exchange Night", 1 },
                    { 22, 2, new DateTime(2026, 4, 24, 0, 0, 0, 0, DateTimeKind.Local), "Showcase of student-built robotics projects.", new DateTime(2026, 4, 24, 12, 30, 0, 0, DateTimeKind.Local), true, "Tech Lab", 460, "Robotics Club", new DateTime(2026, 4, 24, 9, 0, 0, 0, DateTimeKind.Local), "Robotics Demo Day", 2 },
                    { 23, 3, new DateTime(2026, 4, 26, 0, 0, 0, 0, DateTimeKind.Local), "Improve storytelling skills through guided exercises.", new DateTime(2026, 4, 26, 17, 0, 0, 0, DateTimeKind.Local), false, "Workshop Room", 240, "Writers Guild", new DateTime(2026, 4, 26, 15, 0, 0, 0, DateTimeKind.Local), "Creative Writing Workshop", 3 },
                    { 24, 5, new DateTime(2026, 4, 28, 0, 0, 0, 0, DateTimeKind.Local), "Learn to prepare nutritious meals for the week.", new DateTime(2026, 4, 28, 13, 0, 0, 0, DateTimeKind.Local), true, "Kitchen Studio", 210, "Wellness Kitchen", new DateTime(2026, 4, 28, 11, 0, 0, 0, DateTimeKind.Local), "Healthy Meal Prep", 4 },
                    { 25, 4, new DateTime(2026, 4, 30, 0, 0, 0, 0, DateTimeKind.Local), "Peer discussion on leadership challenges and solutions.", new DateTime(2026, 4, 30, 16, 0, 0, 0, DateTimeKind.Local), false, "Executive Lounge", 260, "Leadership Forum", new DateTime(2026, 4, 30, 14, 0, 0, 0, DateTimeKind.Local), "Leadership Roundtable", 5 },
                    { 26, 1, new DateTime(2026, 5, 2, 0, 0, 0, 0, DateTimeKind.Local), "Casual city cycling with planned rest stops.", new DateTime(2026, 5, 2, 11, 30, 0, 0, DateTimeKind.Local), true, "Central Square", 340, "Urban Cyclists", new DateTime(2026, 5, 2, 9, 0, 0, 0, DateTimeKind.Local), "Cycling Meetup", 6 },
                    { 27, 3, new DateTime(2026, 5, 4, 0, 0, 0, 0, DateTimeKind.Local), "Group discussion after a classic film screening.", new DateTime(2026, 5, 4, 21, 0, 0, 0, DateTimeKind.Local), true, "Cinema Hall", 390, "Film Society", new DateTime(2026, 5, 4, 19, 0, 0, 0, DateTimeKind.Local), "Film Discussion Night", 7 },
                    { 28, 2, new DateTime(2026, 5, 6, 0, 0, 0, 0, DateTimeKind.Local), "Intensive introduction to data analysis tools and methods.", new DateTime(2026, 5, 6, 17, 0, 0, 0, DateTimeKind.Local), false, "Training Lab", 480, "Data Academy", new DateTime(2026, 5, 6, 9, 0, 0, 0, DateTimeKind.Local), "Data Analytics Bootcamp", 8 },
                    { 29, 1, new DateTime(2026, 5, 8, 0, 0, 0, 0, DateTimeKind.Local), "Learn seasonal garden planning techniques.", new DateTime(2026, 5, 8, 12, 0, 0, 0, DateTimeKind.Local), true, "Botanical Garden", 230, "Green Thumb Club", new DateTime(2026, 5, 8, 10, 0, 0, 0, DateTimeKind.Local), "Garden Planning Session", 9 },
                    { 30, 1, new DateTime(2026, 5, 10, 0, 0, 0, 0, DateTimeKind.Local), "Orientation session for new volunteers to learn about upcoming community projects.", new DateTime(2026, 5, 10, 12, 0, 0, 0, DateTimeKind.Local), true, "Community Center", 300, "City Volunteers", new DateTime(2026, 5, 10, 9, 0, 0, 0, DateTimeKind.Local), "Volunteer Orientation", 10 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.AlterColumn<TimeSpan>(
                name: "StartTime",
                table: "Activities",
                type: "time",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<TimeSpan>(
                name: "EndTime",
                table: "Activities",
                type: "time",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");
        }
    }
}
