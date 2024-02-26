using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SabeelAPI.Migrations
{
    /// <inheritdoc />
    public partial class DataSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
        migrationBuilder.Sql("INSERT INTO AspNetRoles (Id, Name, NormalizedName) VALUES ('1', 'Admin', 'ADMIN')");
      migrationBuilder.RenameColumn(
                name: "About",
                table: "Details",
                newName: "About3");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "TeemMembers",
                type: "int",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "About1",
                table: "Details",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "About2",
                table: "Details",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "Id", "Address", "Email", "PhoneNumber" },
                values: new object[] { 1, "AUC, New Cairo, Egypt", "Sabeel@aucegyp.edu", "123-456-7890" });

            migrationBuilder.InsertData(
                table: "Details",
                columns: new[] { "Id", "About1", "About2", "About3", "Attendees", "Events", "EventsGoal", "Mission", "YearsOfExperience", "funds", "vision" },
                values: new object[] { 1, "Sabeel is a dynamic and innovative youth-centered organization dedicated to cultivating the growth of intellectually empowered individuals deeply inspired by the richness of Arab culture, identity, and ideology.", "At the core of our mission is the cultivation of critical thinking and the encouragement of creativity among our members. We believe in instilling a profound sense of curiosity and exploration, empowering young minds to engage thoughtfully with the world around them while embracing the values and traditions of the Arab world.", "Our diverse range of programs and initiatives is meticulously designed to foster a spirit of questioning and inquiry. Whether it's through educational workshops, cultural exchanges, or community projects, we strive to provide avenues for personal growth and societal impact.", 4312, 23, "Our goal is to create a platform for Arab youth to engage with their culture, history, and identity, and to provide them with the tools and resources to become leaders and change-makers in their communities.", "Our mission is to inspire and empower the Arab youth to become leaders and change-makers in their communities, while fostering a deep sense of pride and appreciation for their cultural heritage.", 13, 90000, "Our vision is to create a global community of Arab youth who are intellectually curious, culturally aware, and socially responsible, and who are committed to making a positive impact in the world." });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "Date", "Description", "Duration", "Image", "IsNonAucianAllowed", "Title", "price" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Arab Youth Summit is an annual event that brings together young people from across the Arab world to engage in dialogue, exchange ideas, and develop innovative solutions to the challenges facing their communities. The summit features a wide range of workshops, panel discussions, and cultural activities, providing participants with the opportunity to connect with like-minded peers and gain valuable skills and knowledge.", "", "https://via.placeholder.com/150", false, "Arab Youth Summit", "Free" },
                    { 2, new DateTime(2022, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Cultural Exchange Program is a unique opportunity for young people to immerse themselves in the rich cultural heritage of the Arab world. Participants will have the chance to explore historical sites, engage with local communities, and learn about the traditions and customs of the region. The program aims to foster a deeper understanding and appreciation of Arab culture and identity, while promoting cross-cultural dialogue and friendship.", "", "https://via.placeholder.com/150", false, "Cultural Exchange Program", "Free" },
                    { 3, new DateTime(2022, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Youth Leadership Workshop is designed to equip young people with the skills and knowledge they need to become effective leaders and change-makers in their communities. Through a series of interactive sessions and activities, participants will learn about leadership styles, communication strategies, and project management, while also gaining insights into the social and political issues facing the Arab world. The workshop aims to inspire and empower young people to take on leadership roles and make a positive impact in their societies.", "", "https://via.placeholder.com/150", false, "Youth Leadership Workshop", "Free" }
                });

            migrationBuilder.InsertData(
                table: "TeemMembers",
                columns: new[] { "Id", "Description", "Image", "Name" },
                values: new object[,]
                {
                    { 1, "Ahmad is the founder of Sabeel and has been a driving force behind the organization since its inception. He is deeply passionate about empowering Arab youth and fostering a sense of pride and appreciation for their cultural heritage.", "", "Ahmad" },
                    { 2, "Ahmad is the founder of Sabeel and has been a driving force behind the organization since its inception. He is deeply passionate about empowering Arab youth and fostering a sense of pride and appreciation for their cultural heritage.", "", "Ahmad" },
                    { 3, "Ahmad is the founder of Sabeel and has been a driving force behind the organization since its inception. He is deeply passionate about empowering Arab youth and fostering a sense of pride and appreciation for their cultural heritage.", "", "Ahmad" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TeemMembers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TeemMembers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TeemMembers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "About1",
                table: "Details");

            migrationBuilder.DropColumn(
                name: "About2",
                table: "Details");

            migrationBuilder.RenameColumn(
                name: "About3",
                table: "Details",
                newName: "About");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "TeemMembers",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");
        }
    }
}
