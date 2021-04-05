using Microsoft.EntityFrameworkCore.Migrations;

namespace SacramentMeetingPlanner.Migrations
{
    public partial class hymnnum : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "IntermediateHymnNumber",
                table: "Meeting",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "IntermediateHymnNumber",
                table: "Meeting",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }
    }
}
