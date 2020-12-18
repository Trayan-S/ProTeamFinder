using Microsoft.EntityFrameworkCore.Migrations;

namespace ProTeamFinder.Data.Migrations
{
    public partial class RenameTeamField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Information",
                table: "Teams",
                newName: "Description");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Teams",
                newName: "Information");
        }
    }
}
