using Microsoft.EntityFrameworkCore.Migrations;

namespace EduHomeFrontToBack25062022.Migrations
{
    public partial class ChooseTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Title",
                table: "NoticeLeftSides");

            migrationBuilder.CreateTable(
                name: "Chooses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Button = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chooses", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Chooses");

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "NoticeLeftSides",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
