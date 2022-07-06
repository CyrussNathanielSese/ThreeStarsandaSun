﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ThreeStarsandaSun.Migrations
{
    public partial class CityANDRestaurantTableFixed2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CityName",
                table: "Restaurant",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CityName",
                table: "Restaurant");
        }
    }
}
