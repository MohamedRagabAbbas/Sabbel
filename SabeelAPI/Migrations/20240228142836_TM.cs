using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SabeelAPI.Migrations
{
    /// <inheritdoc />
    public partial class TM : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Image_TeemMembers_TeemMemberId",
                table: "Image");

            migrationBuilder.RenameColumn(
                name: "TeemMemberId",
                table: "Image",
                newName: "TeamMemberId");

            migrationBuilder.RenameIndex(
                name: "IX_Image_TeemMemberId",
                table: "Image",
                newName: "IX_Image_TeamMemberId");

            migrationBuilder.AddForeignKey(
                name: "FK_Image_TeemMembers_TeamMemberId",
                table: "Image",
                column: "TeamMemberId",
                principalTable: "TeemMembers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Image_TeemMembers_TeamMemberId",
                table: "Image");

            migrationBuilder.RenameColumn(
                name: "TeamMemberId",
                table: "Image",
                newName: "TeemMemberId");

            migrationBuilder.RenameIndex(
                name: "IX_Image_TeamMemberId",
                table: "Image",
                newName: "IX_Image_TeemMemberId");

            migrationBuilder.AddForeignKey(
                name: "FK_Image_TeemMembers_TeemMemberId",
                table: "Image",
                column: "TeemMemberId",
                principalTable: "TeemMembers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
