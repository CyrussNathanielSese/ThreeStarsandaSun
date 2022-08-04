using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ThreeStarsandaSun.Migrations
{
    public partial class RestoTableAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RestaurantNum",
                table: "Restaurant",
                newName: "RestoContactNumber");

            migrationBuilder.RenameColumn(
                name: "RestaurantName",
                table: "Restaurant",
                newName: "RestoName");

            migrationBuilder.RenameColumn(
                name: "RestaurantAddress",
                table: "Restaurant",
                newName: "RestoAddress");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RestoName",
                table: "Restaurant",
                newName: "RestaurantName");

            migrationBuilder.RenameColumn(
                name: "RestoContactNumber",
                table: "Restaurant",
                newName: "RestaurantNum");

            migrationBuilder.RenameColumn(
                name: "RestoAddress",
                table: "Restaurant",
                newName: "RestaurantAddress");
        }
    }
}
