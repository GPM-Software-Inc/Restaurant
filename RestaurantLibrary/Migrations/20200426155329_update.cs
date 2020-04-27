using Microsoft.EntityFrameworkCore.Migrations;

namespace RestaurantLibrary.Migrations
{
    public partial class update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Themes",
                table: "TaskModels",
                maxLength: 100,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Themes",
                table: "TaskModels");
        }
    }
}
