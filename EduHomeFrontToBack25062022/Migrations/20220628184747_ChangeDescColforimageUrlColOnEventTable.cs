using Microsoft.EntityFrameworkCore.Migrations;

namespace EduHomeFrontToBack25062022.Migrations
{
    public partial class ChangeDescColforimageUrlColOnEventTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Events");

            migrationBuilder.AddColumn<string>(
                name: "imageUrl",
                table: "Events",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "imageUrl",
                table: "Events");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Events",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
