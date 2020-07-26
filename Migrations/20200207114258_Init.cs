using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IzhCloud_Timetable.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Entries",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(nullable: false),
                    FirstFirst = table.Column<string>(nullable: true),
                    FirstSecond = table.Column<string>(nullable: true),
                    SecondFirst = table.Column<string>(nullable: true),
                    SecondSecond = table.Column<string>(nullable: true),
                    ThirdFirst = table.Column<string>(nullable: true),
                    ThirdSecond = table.Column<string>(nullable: true),
                    FourthFirst = table.Column<string>(nullable: true),
                    FourthSecond = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entries", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Entries");
        }
    }
}
