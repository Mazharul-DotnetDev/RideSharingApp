using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorAppServer.Migrations
{
    /// <inheritdoc />
    public partial class Mig1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Ride",
                columns: table => new
                {
                    RideId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartureLocation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Destination = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DepartureTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VehicleType = table.Column<int>(type: "int", nullable: false),
                    RideDetails = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstimatedFare = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsSmokingAllowed = table.Column<bool>(type: "bit", nullable: false),
                    RideDuration = table.Column<TimeSpan>(type: "time", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ride", x => x.RideId);
                    table.ForeignKey(
                        name: "FK_Ride_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "UserId", "Phone", "Username" },
                values: new object[,]
                {
                    { 1, "123-456-7890", "JohnDoe" },
                    { 2, "987-654-3210", "JaneSmith" },
                    { 3, "555-555-5555", "AliceWonder" },
                    { 4, "999-999-9999", "BobBuilder" },
                    { 5, "666-666-6666", "EveHacker" },
                    { 6, "123-456-7890", "JohnDoe" },
                    { 7, "987-654-3210", "JaneSmith" },
                    { 8, "555-555-5555", "AliceWonder" },
                    { 9, "999-999-9999", "BobBuilder" },
                    { 10, "666-666-6666", "EveHacker" }
                });

            migrationBuilder.InsertData(
                table: "Ride",
                columns: new[] { "RideId", "DepartureLocation", "DepartureTime", "Destination", "EstimatedFare", "IsSmokingAllowed", "RideDetails", "RideDuration", "UserId", "VehicleType" },
                values: new object[,]
                {
                    { 1, "City A", new DateTime(2024, 3, 12, 1, 30, 55, 445, DateTimeKind.Local).AddTicks(7701), "City B", 50.00m, false, "Comfortable sedan, music available", new TimeSpan(0, 3, 0, 0, 0), 1, 3 },
                    { 2, "City C", new DateTime(2024, 3, 12, 2, 30, 55, 445, DateTimeKind.Local).AddTicks(7722), "City D", 80.00m, false, "Spacious van, no smoking", new TimeSpan(0, 4, 0, 0, 0), 2, 1 },
                    { 3, "City A", new DateTime(2024, 3, 12, 1, 30, 55, 445, DateTimeKind.Local).AddTicks(7728), "City B", 50.00m, false, "Comfortable sedan, music available", new TimeSpan(0, 3, 0, 0, 0), 3, 3 },
                    { 4, "City C", new DateTime(2024, 3, 12, 2, 30, 55, 445, DateTimeKind.Local).AddTicks(7734), "City D", 80.00m, false, "Spacious van, no smoking", new TimeSpan(0, 4, 0, 0, 0), 4, 1 },
                    { 5, "City A", new DateTime(2024, 3, 12, 1, 30, 55, 445, DateTimeKind.Local).AddTicks(7741), "City B", 50.00m, false, "Comfortable sedan, music available", new TimeSpan(0, 3, 0, 0, 0), 5, 3 },
                    { 6, "City C", new DateTime(2024, 3, 12, 2, 30, 55, 445, DateTimeKind.Local).AddTicks(7746), "City D", 80.00m, false, "Spacious van, no smoking", new TimeSpan(0, 4, 0, 0, 0), 6, 1 },
                    { 7, "City A", new DateTime(2024, 3, 12, 1, 30, 55, 445, DateTimeKind.Local).AddTicks(7752), "City B", 50.00m, false, "Comfortable sedan, music available", new TimeSpan(0, 3, 0, 0, 0), 7, 3 },
                    { 8, "City C", new DateTime(2024, 3, 12, 2, 30, 55, 445, DateTimeKind.Local).AddTicks(7758), "City D", 80.00m, false, "Spacious van, no smoking", new TimeSpan(0, 4, 0, 0, 0), 8, 1 },
                    { 9, "City A", new DateTime(2024, 3, 12, 1, 30, 55, 445, DateTimeKind.Local).AddTicks(7764), "City B", 50.00m, false, "Comfortable sedan, music available", new TimeSpan(0, 3, 0, 0, 0), 9, 3 },
                    { 10, "City C", new DateTime(2024, 3, 12, 2, 30, 55, 445, DateTimeKind.Local).AddTicks(7770), "City D", 80.00m, false, "Spacious van, no smoking", new TimeSpan(0, 4, 0, 0, 0), 10, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ride_UserId",
                table: "Ride",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ride");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
