using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PainTrackerPT.Migrations
{
    public partial class hi2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "EventsLog",
                newName: "moduleType");

            migrationBuilder.AddColumn<string>(
                name: "eventDesc",
                table: "EventsLog",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "eventEndDate",
                table: "EventsLog",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "eventStartDate",
                table: "EventsLog",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "eventTitle",
                table: "EventsLog",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "eventDesc",
                table: "EventsLog");

            migrationBuilder.DropColumn(
                name: "eventEndDate",
                table: "EventsLog");

            migrationBuilder.DropColumn(
                name: "eventStartDate",
                table: "EventsLog");

            migrationBuilder.DropColumn(
                name: "eventTitle",
                table: "EventsLog");

            migrationBuilder.RenameColumn(
                name: "moduleType",
                table: "EventsLog",
                newName: "Description");

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    eventDesc = table.Column<string>(nullable: true),
                    eventEndDate = table.Column<DateTime>(nullable: false),
                    eventStartDate = table.Column<DateTime>(nullable: false),
                    eventTitle = table.Column<string>(nullable: true),
                    moduleType = table.Column<string>(nullable: true),
                    timeStamp = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.Id);
                });
        }
    }
}
