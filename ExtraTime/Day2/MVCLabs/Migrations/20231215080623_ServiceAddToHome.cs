using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVCLabs.Migrations
{
    public partial class ServiceAddToHome : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "colorCode",
                table: "Services",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "colorCode",
                table: "Services");
        }
    }
}
