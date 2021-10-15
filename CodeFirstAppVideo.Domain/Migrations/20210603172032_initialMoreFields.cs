using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirstAppVideo.Domain.Migrations
{
    public partial class initialMoreFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateAt",
                table: "Video",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Video",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateAt",
                table: "Genre",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Video");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateAt",
                table: "Video",
                type: "datetime",
                nullable: false,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateAt",
                table: "Genre",
                type: "datetime",
                nullable: false,
                oldClrType: typeof(DateTime));
        }
    }
}
