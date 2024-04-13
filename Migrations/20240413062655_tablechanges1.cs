using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PatrolPal.Migrations
{
    /// <inheritdoc />
    public partial class tablechanges1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "District",
                table: "PoliceStations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "District",
                table: "CameraLocation",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "District",
                table: "PoliceStations");

            migrationBuilder.DropColumn(
                name: "District",
                table: "CameraLocation");
        }
    }
}
