using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace WebApplicationHotelBoeking.Migrations
{
    public partial class secondmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_hotelBoeking",
                table: "hotelBoeking");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "hotelBoeking");

            migrationBuilder.DropColumn(
                name: "Booking_id",
                table: "hotelBoeking");

            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "hotelBoeking");

            migrationBuilder.DropColumn(
                name: "Guest_No",
                table: "hotelBoeking");

            migrationBuilder.DropColumn(
                name: "Room_No",
                table: "hotelBoeking");

            migrationBuilder.DropColumn(
                name: "StartDate",
                table: "hotelBoeking");

            migrationBuilder.RenameTable(
                name: "hotelBoeking",
                newName: "HotelBoeking");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HotelBoeking",
                table: "HotelBoeking",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_HotelBoeking",
                table: "HotelBoeking");

            migrationBuilder.RenameTable(
                name: "HotelBoeking",
                newName: "hotelBoeking");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "hotelBoeking",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Booking_id",
                table: "hotelBoeking",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate",
                table: "hotelBoeking",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Guest_No",
                table: "hotelBoeking",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Room_No",
                table: "hotelBoeking",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "StartDate",
                table: "hotelBoeking",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddPrimaryKey(
                name: "PK_hotelBoeking",
                table: "hotelBoeking",
                column: "Id");
        }
    }
}
