using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SabeelAPI.Migrations
{
    /// <inheritdoc />
    public partial class addNewRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
          // add role for admin
          migrationBuilder.Sql("INSERT INTO AspNetRoles (Id, Name, NormalizedName) VALUES ('1', 'Admin', 'ADMIN')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
           // remove role for admin
           migrationBuilder.Sql("DELETE FROM AspNetRoles WHERE Id = '1'");
        }
    }
}
