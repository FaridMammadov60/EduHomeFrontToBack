using Microsoft.EntityFrameworkCore.Migrations;

namespace EduHomeFrontToBack25062022.Migrations
{
    public partial class PositonColumnAddTeacherTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Position",
                table: "Teachers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Position",
                table: "Teachers");
        }
    }
}
