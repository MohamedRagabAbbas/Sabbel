using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SabeelAPI.Migrations
{
    /// <inheritdoc />
    public partial class newMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Events_Image_ImageId",
                table: "Events");

            migrationBuilder.DropForeignKey(
                name: "FK_TeemMembers_Image_ImageId",
                table: "TeemMembers");

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Image_ImageId",
                table: "Events",
                column: "ImageId",
                principalTable: "Image",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TeemMembers_Image_ImageId",
                table: "TeemMembers",
                column: "ImageId",
                principalTable: "Image",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Events_Image_ImageId",
                table: "Events");

            migrationBuilder.DropForeignKey(
                name: "FK_TeemMembers_Image_ImageId",
                table: "TeemMembers");

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Image_ImageId",
                table: "Events",
                column: "ImageId",
                principalTable: "Image",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TeemMembers_Image_ImageId",
                table: "TeemMembers",
                column: "ImageId",
                principalTable: "Image",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
