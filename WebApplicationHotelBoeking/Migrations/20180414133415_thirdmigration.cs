using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace WebApplicationHotelBoeking.Migrations
{
    public partial class thirdmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "HotelBoeking",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Booking_id",
                table: "HotelBoeking",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate",
                table: "HotelBoeking",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Guest_No",
                table: "HotelBoeking",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Room_No",
                table: "HotelBoeking",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "StartDate",
                table: "HotelBoeking",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "HotelBoeking");

            migrationBuilder.DropColumn(
                name: "Booking_id",
                table: "HotelBoeking");

            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "HotelBoeking");

            migrationBuilder.DropColumn(
                name: "Guest_No",
                table: "HotelBoeking");

            migrationBuilder.DropColumn(
                name: "Room_No",
                table: "HotelBoeking");

            migrationBuilder.DropColumn(
                name: "StartDate",
                table: "HotelBoeking");
        }
    }
}
