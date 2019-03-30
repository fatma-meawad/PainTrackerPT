using Microsoft.EntityFrameworkCore.Migrations;

namespace PainTrackerPT.Migrations
{
    public partial class UpdatedMedEvent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TimeStamp",
                table: "MedicineEvent",
                newName: "StartTime");

            migrationBuilder.AddColumn<int>(
                name: "Intervals",
                table: "MedicineEvent",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NumOfRecurringTimes",
                table: "MedicineEvent",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Intervals",
                table: "MedicineEvent");

            migrationBuilder.DropColumn(
                name: "NumOfRecurringTimes",
                table: "MedicineEvent");

            migrationBuilder.RenameColumn(
                name: "StartTime",
                table: "MedicineEvent",
                newName: "TimeStamp");
        }
    }
}
