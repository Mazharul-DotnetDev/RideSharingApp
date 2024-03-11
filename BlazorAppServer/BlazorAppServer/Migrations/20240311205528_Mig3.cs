using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorAppServer.Migrations
{
    /// <inheritdoc />
    public partial class Mig3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "VehicleType",
                table: "Ride",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Ride",
                keyColumn: "RideId",
                keyValue: 1,
                columns: new[] { "DepartureTime", "DepartureTimeFormatted", "VehicleType" },
                values: new object[] { new DateTime(2024, 3, 12, 3, 55, 25, 377, DateTimeKind.Local).AddTicks(3205), "2024-03-12 03:55", "Car" });

            migrationBuilder.UpdateData(
                table: "Ride",
                keyColumn: "RideId",
                keyValue: 2,
                columns: new[] { "DepartureTime", "DepartureTimeFormatted", "VehicleType" },
                values: new object[] { new DateTime(2024, 3, 12, 4, 55, 25, 377, DateTimeKind.Local).AddTicks(3225), "2024-03-12 04:55", "Car" });

            migrationBuilder.UpdateData(
                table: "Ride",
                keyColumn: "RideId",
                keyValue: 3,
                columns: new[] { "DepartureTime", "DepartureTimeFormatted", "VehicleType" },
                values: new object[] { new DateTime(2024, 3, 12, 3, 55, 25, 377, DateTimeKind.Local).AddTicks(3321), "2024-03-12 03:55", "Car" });

            migrationBuilder.UpdateData(
                table: "Ride",
                keyColumn: "RideId",
                keyValue: 4,
                columns: new[] { "DepartureTime", "DepartureTimeFormatted", "VehicleType" },
                values: new object[] { new DateTime(2024, 3, 12, 4, 55, 25, 377, DateTimeKind.Local).AddTicks(3327), "2024-03-12 04:55", "Car" });

            migrationBuilder.UpdateData(
                table: "Ride",
                keyColumn: "RideId",
                keyValue: 5,
                columns: new[] { "DepartureTime", "DepartureTimeFormatted", "VehicleType" },
                values: new object[] { new DateTime(2024, 3, 12, 3, 55, 25, 377, DateTimeKind.Local).AddTicks(3331), "2024-03-12 03:55", "Car" });

            migrationBuilder.UpdateData(
                table: "Ride",
                keyColumn: "RideId",
                keyValue: 6,
                columns: new[] { "DepartureTime", "DepartureTimeFormatted", "VehicleType" },
                values: new object[] { new DateTime(2024, 3, 12, 4, 55, 25, 377, DateTimeKind.Local).AddTicks(3336), "2024-03-12 04:55", "Car" });

            migrationBuilder.UpdateData(
                table: "Ride",
                keyColumn: "RideId",
                keyValue: 7,
                columns: new[] { "DepartureTime", "DepartureTimeFormatted", "VehicleType" },
                values: new object[] { new DateTime(2024, 3, 12, 3, 55, 25, 377, DateTimeKind.Local).AddTicks(3340), "2024-03-12 03:55", "Car" });

            migrationBuilder.UpdateData(
                table: "Ride",
                keyColumn: "RideId",
                keyValue: 8,
                columns: new[] { "DepartureTime", "DepartureTimeFormatted", "VehicleType" },
                values: new object[] { new DateTime(2024, 3, 12, 4, 55, 25, 377, DateTimeKind.Local).AddTicks(3345), "2024-03-12 04:55", "Car" });

            migrationBuilder.UpdateData(
                table: "Ride",
                keyColumn: "RideId",
                keyValue: 9,
                columns: new[] { "DepartureTime", "DepartureTimeFormatted", "VehicleType" },
                values: new object[] { new DateTime(2024, 3, 12, 3, 55, 25, 377, DateTimeKind.Local).AddTicks(3349), "2024-03-12 03:55", "Car" });

            migrationBuilder.UpdateData(
                table: "Ride",
                keyColumn: "RideId",
                keyValue: 10,
                columns: new[] { "DepartureTime", "DepartureTimeFormatted", "VehicleType" },
                values: new object[] { new DateTime(2024, 3, 12, 4, 55, 25, 377, DateTimeKind.Local).AddTicks(3354), "2024-03-12 04:55", "Car" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "VehicleType",
                table: "Ride",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Ride",
                keyColumn: "RideId",
                keyValue: 1,
                columns: new[] { "DepartureTime", "DepartureTimeFormatted", "VehicleType" },
                values: new object[] { new DateTime(2024, 3, 12, 3, 8, 36, 992, DateTimeKind.Local).AddTicks(4058), "2024-03-12 03:08", 3 });

            migrationBuilder.UpdateData(
                table: "Ride",
                keyColumn: "RideId",
                keyValue: 2,
                columns: new[] { "DepartureTime", "DepartureTimeFormatted", "VehicleType" },
                values: new object[] { new DateTime(2024, 3, 12, 4, 8, 36, 992, DateTimeKind.Local).AddTicks(4076), "2024-03-12 04:08", 1 });

            migrationBuilder.UpdateData(
                table: "Ride",
                keyColumn: "RideId",
                keyValue: 3,
                columns: new[] { "DepartureTime", "DepartureTimeFormatted", "VehicleType" },
                values: new object[] { new DateTime(2024, 3, 12, 3, 8, 36, 992, DateTimeKind.Local).AddTicks(4082), "2024-03-12 03:08", 3 });

            migrationBuilder.UpdateData(
                table: "Ride",
                keyColumn: "RideId",
                keyValue: 4,
                columns: new[] { "DepartureTime", "DepartureTimeFormatted", "VehicleType" },
                values: new object[] { new DateTime(2024, 3, 12, 4, 8, 36, 992, DateTimeKind.Local).AddTicks(4087), "2024-03-12 04:08", 1 });

            migrationBuilder.UpdateData(
                table: "Ride",
                keyColumn: "RideId",
                keyValue: 5,
                columns: new[] { "DepartureTime", "DepartureTimeFormatted", "VehicleType" },
                values: new object[] { new DateTime(2024, 3, 12, 3, 8, 36, 992, DateTimeKind.Local).AddTicks(4092), "2024-03-12 03:08", 3 });

            migrationBuilder.UpdateData(
                table: "Ride",
                keyColumn: "RideId",
                keyValue: 6,
                columns: new[] { "DepartureTime", "DepartureTimeFormatted", "VehicleType" },
                values: new object[] { new DateTime(2024, 3, 12, 4, 8, 36, 992, DateTimeKind.Local).AddTicks(4096), "2024-03-12 04:08", 1 });

            migrationBuilder.UpdateData(
                table: "Ride",
                keyColumn: "RideId",
                keyValue: 7,
                columns: new[] { "DepartureTime", "DepartureTimeFormatted", "VehicleType" },
                values: new object[] { new DateTime(2024, 3, 12, 3, 8, 36, 992, DateTimeKind.Local).AddTicks(4101), "2024-03-12 03:08", 3 });

            migrationBuilder.UpdateData(
                table: "Ride",
                keyColumn: "RideId",
                keyValue: 8,
                columns: new[] { "DepartureTime", "DepartureTimeFormatted", "VehicleType" },
                values: new object[] { new DateTime(2024, 3, 12, 4, 8, 36, 992, DateTimeKind.Local).AddTicks(4105), "2024-03-12 04:08", 1 });

            migrationBuilder.UpdateData(
                table: "Ride",
                keyColumn: "RideId",
                keyValue: 9,
                columns: new[] { "DepartureTime", "DepartureTimeFormatted", "VehicleType" },
                values: new object[] { new DateTime(2024, 3, 12, 3, 8, 36, 992, DateTimeKind.Local).AddTicks(4260), "2024-03-12 03:08", 3 });

            migrationBuilder.UpdateData(
                table: "Ride",
                keyColumn: "RideId",
                keyValue: 10,
                columns: new[] { "DepartureTime", "DepartureTimeFormatted", "VehicleType" },
                values: new object[] { new DateTime(2024, 3, 12, 4, 8, 36, 992, DateTimeKind.Local).AddTicks(4265), "2024-03-12 04:08", 1 });
        }
    }
}
