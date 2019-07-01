using Microsoft.EntityFrameworkCore.Migrations;

namespace trans_track.Data.Migrations
{
    public partial class AddServiceTypeToService : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ServiceType",
                table: "Service");

            migrationBuilder.AddColumn<int>(
                name: "ServiceTypeID",
                table: "Service",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Service_ServiceTypeID",
                table: "Service",
                column: "ServiceTypeID");

            migrationBuilder.AddForeignKey(
                name: "FK_Service_ServiceType_ServiceTypeID",
                table: "Service",
                column: "ServiceTypeID",
                principalTable: "ServiceType",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Service_ServiceType_ServiceTypeID",
                table: "Service");

            migrationBuilder.DropIndex(
                name: "IX_Service_ServiceTypeID",
                table: "Service");

            migrationBuilder.DropColumn(
                name: "ServiceTypeID",
                table: "Service");

            migrationBuilder.AddColumn<string>(
                name: "ServiceType",
                table: "Service",
                nullable: true);
        }
    }
}
