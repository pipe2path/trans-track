using Microsoft.EntityFrameworkCore.Migrations;

namespace trans_track.Data.Migrations
{
    public partial class VehicleAddWarning : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Warning",
                table: "Vehicle",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "WarningMessage",
                table: "Vehicle",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Warning",
                table: "Vehicle");

            migrationBuilder.DropColumn(
                name: "WarningMessage",
                table: "Vehicle");

        }
    }
}
