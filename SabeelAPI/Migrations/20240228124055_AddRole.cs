using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SabeelAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // add role for admin SQL
            migrationBuilder.Sql("INSERT INTO AspNetRoles (Id, Name, NormalizedName) VALUES ('1', 'Admin', 'ADMIN')");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
          //drop role for admin SQL
          migrationBuilder.Sql("DELETE FROM AspNetRoles WHERE Id = '1'");
        }
    }
}
