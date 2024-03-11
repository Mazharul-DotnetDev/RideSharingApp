using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorAppServer.Migrations
{
    /// <inheritdoc />
    public partial class Mig2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DepartureTimeFormatted",
                table: "Ride",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Ride",
                keyColumn: "RideId",
                keyValue: 1,
                columns: new[] { "DepartureTime", "DepartureTimeFormatted" },
                values: new object[] { new DateTime(2024, 3, 12, 3, 8, 36, 992, DateTimeKind.Local).AddTicks(4058), "2024-03-12 03:08" });

            migrationBuilder.UpdateData(
                table: "Ride",
                keyColumn: "RideId",
                keyValue: 2,
                columns: new[] { "DepartureTime", "DepartureTimeFormatted" },
                values: new object[] { new DateTime(2024, 3, 12, 4, 8, 36, 992, DateTimeKind.Local).AddTicks(4076), "2024-03-12 04:08" });

            migrationBuilder.UpdateData(
                table: "Ride",
                keyColumn: "RideId",
                keyValue: 3,
                columns: new[] { "DepartureTime", "DepartureTimeFormatted" },
                values: new object[] { new DateTime(2024, 3, 12, 3, 8, 36, 992, DateTimeKind.Local).AddTicks(4082), "2024-03-12 03:08" });

            migrationBuilder.UpdateData(
                table: "Ride",
                keyColumn: "RideId",
                keyValue: 4,
                columns: new[] { "DepartureTime", "DepartureTimeFormatted" },
                values: new object[] { new DateTime(2024, 3, 12, 4, 8, 36, 992, DateTimeKind.Local).AddTicks(4087), "2024-03-12 04:08" });

            migrationBuilder.UpdateData(
                table: "Ride",
                keyColumn: "RideId",
                keyValue: 5,
                columns: new[] { "DepartureTime", "DepartureTimeFormatted" },
                values: new object[] { new DateTime(2024, 3, 12, 3, 8, 36, 992, DateTimeKind.Local).AddTicks(4092), "2024-03-12 03:08" });

            migrationBuilder.UpdateData(
                table: "Ride",
                keyColumn: "RideId",
                keyValue: 6,
                columns: new[] { "DepartureTime", "DepartureTimeFormatted" },
                values: new object[] { new DateTime(2024, 3, 12, 4, 8, 36, 992, DateTimeKind.Local).AddTicks(4096), "2024-03-12 04:08" });

            migrationBuilder.UpdateData(
                table: "Ride",
                keyColumn: "RideId",
                keyValue: 7,
                columns: new[] { "DepartureTime", "DepartureTimeFormatted" },
                values: new object[] { new DateTime(2024, 3, 12, 3, 8, 36, 992, DateTimeKind.Local).AddTicks(4101), "2024-03-12 03:08" });

            migrationBuilder.UpdateData(
                table: "Ride",
                keyColumn: "RideId",
                keyValue: 8,
                columns: new[] { "DepartureTime", "DepartureTimeFormatted" },
                values: new object[] { new DateTime(2024, 3, 12, 4, 8, 36, 992, DateTimeKind.Local).AddTicks(4105), "2024-03-12 04:08" });

            migrationBuilder.UpdateData(
                table: "Ride",
                keyColumn: "RideId",
                keyValue: 9,
                columns: new[] { "DepartureTime", "DepartureTimeFormatted" },
                values: new object[] { new DateTime(2024, 3, 12, 3, 8, 36, 992, DateTimeKind.Local).AddTicks(4260), "2024-03-12 03:08" });

            migrationBuilder.UpdateData(
                table: "Ride",
                keyColumn: "RideId",
                keyValue: 10,
                columns: new[] { "DepartureTime", "DepartureTimeFormatted" },
                values: new object[] { new DateTime(2024, 3, 12, 4, 8, 36, 992, DateTimeKind.Local).AddTicks(4265), "2024-03-12 04:08" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DepartureTimeFormatted",
                table: "Ride");

            migrationBuilder.UpdateData(
                table: "Ride",
                keyColumn: "RideId",
                keyValue: 1,
                column: "DepartureTime",
                value: new DateTime(2024, 3, 12, 1, 30, 55, 445, DateTimeKind.Local).AddTicks(7701));

            migrationBuilder.UpdateData(
                table: "Ride",
                keyColumn: "RideId",
                keyValue: 2,
                column: "DepartureTime",
                value: new DateTime(2024, 3, 12, 2, 30, 55, 445, DateTimeKind.Local).AddTicks(7722));

            migrationBuilder.UpdateData(
                table: "Ride",
                keyColumn: "RideId",
                keyValue: 3,
                column: "DepartureTime",
                value: new DateTime(2024, 3, 12, 1, 30, 55, 445, DateTimeKind.Local).AddTicks(7728));

            migrationBuilder.UpdateData(
                table: "Ride",
                keyColumn: "RideId",
                keyValue: 4,
                column: "DepartureTime",
                value: new DateTime(2024, 3, 12, 2, 30, 55, 445, DateTimeKind.Local).AddTicks(7734));

            migrationBuilder.UpdateData(
                table: "Ride",
                keyColumn: "RideId",
                keyValue: 5,
                column: "DepartureTime",
                value: new DateTime(2024, 3, 12, 1, 30, 55, 445, DateTimeKind.Local).AddTicks(7741));

            migrationBuilder.UpdateData(
                table: "Ride",
                keyColumn: "RideId",
                keyValue: 6,
                column: "DepartureTime",
                value: new DateTime(2024, 3, 12, 2, 30, 55, 445, DateTimeKind.Local).AddTicks(7746));

            migrationBuilder.UpdateData(
                table: "Ride",
                keyColumn: "RideId",
                keyValue: 7,
                column: "DepartureTime",
                value: new DateTime(2024, 3, 12, 1, 30, 55, 445, DateTimeKind.Local).AddTicks(7752));

            migrationBuilder.UpdateData(
                table: "Ride",
                keyColumn: "RideId",
                keyValue: 8,
                column: "DepartureTime",
                value: new DateTime(2024, 3, 12, 2, 30, 55, 445, DateTimeKind.Local).AddTicks(7758));

            migrationBuilder.UpdateData(
                table: "Ride",
                keyColumn: "RideId",
                keyValue: 9,
                column: "DepartureTime",
                value: new DateTime(2024, 3, 12, 1, 30, 55, 445, DateTimeKind.Local).AddTicks(7764));

            migrationBuilder.UpdateData(
                table: "Ride",
                keyColumn: "RideId",
                keyValue: 10,
                column: "DepartureTime",
                value: new DateTime(2024, 3, 12, 2, 30, 55, 445, DateTimeKind.Local).AddTicks(7770));
        }
    }
}
