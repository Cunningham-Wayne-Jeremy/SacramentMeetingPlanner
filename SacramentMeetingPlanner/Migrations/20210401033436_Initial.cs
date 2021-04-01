using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SacramentMeetingPlanner.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Meeting",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Subject = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Conducting = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Invocation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Benediction = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OpeningHymn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OpeningHymnNumber = table.Column<int>(type: "int", nullable: false),
                    SacramentHymn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SacramentHymnNumber = table.Column<int>(type: "int", nullable: false),
                    ClosingHymn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClosingHymnNumber = table.Column<int>(type: "int", nullable: false),
                    IntermediateHymn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IntermediateHymnNumber = table.Column<int>(type: "int", nullable: false),
                    FirstSpeaker = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecondSpeaker = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YouthSpeaker = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meeting", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Meeting");
        }
    }
}
