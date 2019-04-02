using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PainTrackerPT.Migrations
{
    public partial class InitialCreate : Migration
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
                    Description = table.Column<string>(nullable: true),
                    timeStamp = table.Column<DateTime>(nullable: false)
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
                name: "MedicineEvent",
                columns: table => new
                {
                    EventId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Dosage = table.Column<int>(nullable: false),
                    StartTime = table.Column<DateTime>(nullable: false),
                    Intervals = table.Column<int>(nullable: false),
                    NumOfRecurringTimes = table.Column<int>(nullable: false),
                    MedId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicineEvent", x => x.EventId);
                    table.ForeignKey(
                    name: "FK_MedicineEvent_MedicineLog_MedId",
                    column: x => x.MedId,
                    principalTable: "MedicineLog",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MedicineEventLog",
                columns: table => new
                {
                    LogId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Dosage = table.Column<int>(nullable: false),
                    CurrentTime = table.Column<DateTime>(nullable: false),
                    EventId = table.Column<int>(nullable: false),
                    MedId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicineEventLog", x => x.LogId);
                    table.ForeignKey(
                    name: "FK_MedicineEventLog_MedicineEvent_EventId",
                    column: x => x.EventId,
                    principalTable: "MedicineEvent",
                    principalColumn: "EventId",
                    onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MedicineLog",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Type = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Img = table.Column<string>(nullable: true),
                    PatientID = table.Column<int>(nullable: false),
                    MedGuid = table.Column<Guid>(nullable: false)
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
                name: "MedicineEvent");

            migrationBuilder.DropTable(
                name: "MedicineEventLog");

            migrationBuilder.DropTable(
                name: "MedicineLog");

            migrationBuilder.DropTable(
                name: "PainDiaryLog");
        }
    }
}
