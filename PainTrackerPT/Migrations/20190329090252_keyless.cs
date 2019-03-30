using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PainTrackerPT.Migrations
{
    public partial class keyless : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AnalyticsLog",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    timeStamp = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnalyticsLog", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DoctorsLog",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    timeStamp = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoctorsLog", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EventsLog",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    timeStamp = table.Column<DateTime>(nullable: false),
                    eventTitle = table.Column<string>(nullable: true),
                    eventStartDate = table.Column<DateTime>(nullable: false),
                    eventEndDate = table.Column<DateTime>(nullable: false),
                    eventDesc = table.Column<string>(nullable: true),
                    moduleType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventsLog", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FollowupsLog",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    timeStamp = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FollowupsLog", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MedicineLog",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    timeStamp = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicineLog", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PainDiaryLog",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    timeStamp = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PainDiaryLog", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnalyticsLog");

            migrationBuilder.DropTable(
                name: "DoctorsLog");

            migrationBuilder.DropTable(
                name: "EventsLog");

            migrationBuilder.DropTable(
                name: "FollowupsLog");

            migrationBuilder.DropTable(
                name: "MedicineLog");

            migrationBuilder.DropTable(
                name: "PainDiaryLog");
        }
    }
}
