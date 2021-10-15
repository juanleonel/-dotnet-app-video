using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirstAppVideo.Domain.Migrations
{
    public partial class gnrechanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Available",
                table: "Genre",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Available",
                table: "Genre");
        }
    }
}
