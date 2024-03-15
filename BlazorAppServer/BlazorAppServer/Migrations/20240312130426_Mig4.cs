using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorAppServer.Migrations
{
    /// <inheritdoc />
    public partial class Mig4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DepartureTimeFormatted",
                table: "Ride");

            migrationBuilder.DropColumn(
                name: "RideDuration",
                table: "Ride");

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "User",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DepartureTime",
                table: "Ride",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "Ride",
                keyColumn: "RideId",
                keyValue: 1,
                column: "DepartureTime",
                value: new DateTime(2024, 3, 12, 20, 4, 24, 110, DateTimeKind.Local).AddTicks(5842));

            migrationBuilder.UpdateData(
                table: "Ride",
                keyColumn: "RideId",
                keyValue: 2,
                column: "DepartureTime",
                value: new DateTime(2024, 3, 12, 21, 4, 24, 110, DateTimeKind.Local).AddTicks(5874));

            migrationBuilder.UpdateData(
                table: "Ride",
                keyColumn: "RideId",
                keyValue: 3,
                column: "DepartureTime",
                value: new DateTime(2024, 3, 12, 20, 4, 24, 110, DateTimeKind.Local).AddTicks(5879));

            migrationBuilder.UpdateData(
                table: "Ride",
                keyColumn: "RideId",
                keyValue: 4,
                column: "DepartureTime",
                value: new DateTime(2024, 3, 12, 21, 4, 24, 110, DateTimeKind.Local).AddTicks(5882));

            migrationBuilder.UpdateData(
                table: "Ride",
                keyColumn: "RideId",
                keyValue: 5,
                column: "DepartureTime",
                value: new DateTime(2024, 3, 12, 20, 4, 24, 110, DateTimeKind.Local).AddTicks(5886));

            migrationBuilder.UpdateData(
                table: "Ride",
                keyColumn: "RideId",
                keyValue: 6,
                column: "DepartureTime",
                value: new DateTime(2024, 3, 12, 21, 4, 24, 110, DateTimeKind.Local).AddTicks(5890));

            migrationBuilder.UpdateData(
                table: "Ride",
                keyColumn: "RideId",
                keyValue: 7,
                column: "DepartureTime",
                value: new DateTime(2024, 3, 12, 20, 4, 24, 110, DateTimeKind.Local).AddTicks(5893));

            migrationBuilder.UpdateData(
                table: "Ride",
                keyColumn: "RideId",
                keyValue: 8,
                column: "DepartureTime",
                value: new DateTime(2024, 3, 12, 21, 4, 24, 110, DateTimeKind.Local).AddTicks(5897));

            migrationBuilder.UpdateData(
                table: "Ride",
                keyColumn: "RideId",
                keyValue: 9,
                column: "DepartureTime",
                value: new DateTime(2024, 3, 12, 20, 4, 24, 110, DateTimeKind.Local).AddTicks(5902));

            migrationBuilder.UpdateData(
                table: "Ride",
                keyColumn: "RideId",
                keyValue: 10,
                column: "DepartureTime",
                value: new DateTime(2024, 3, 12, 21, 4, 24, 110, DateTimeKind.Local).AddTicks(5906));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "User",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DepartureTime",
                table: "Ride",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DepartureTimeFormatted",
                table: "Ride",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<TimeSpan>(
                name: "RideDuration",
                table: "Ride",
                type: "time",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));

            migrationBuilder.UpdateData(
                table: "Ride",
                keyColumn: "RideId",
                keyValue: 1,
                columns: new[] { "DepartureTime", "DepartureTimeFormatted", "RideDuration" },
                values: new object[] { new DateTime(2024, 3, 12, 3, 55, 25, 377, DateTimeKind.Local).AddTicks(3205), "2024-03-12 03:55", new TimeSpan(0, 3, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Ride",
                keyColumn: "RideId",
                keyValue: 2,
                columns: new[] { "DepartureTime", "DepartureTimeFormatted", "RideDuration" },
                values: new object[] { new DateTime(2024, 3, 12, 4, 55, 25, 377, DateTimeKind.Local).AddTicks(3225), "2024-03-12 04:55", new TimeSpan(0, 4, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Ride",
                keyColumn: "RideId",
                keyValue: 3,
                columns: new[] { "DepartureTime", "DepartureTimeFormatted", "RideDuration" },
                values: new object[] { new DateTime(2024, 3, 12, 3, 55, 25, 377, DateTimeKind.Local).AddTicks(3321), "2024-03-12 03:55", new TimeSpan(0, 3, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Ride",
                keyColumn: "RideId",
                keyValue: 4,
                columns: new[] { "DepartureTime", "DepartureTimeFormatted", "RideDuration" },
                values: new object[] { new DateTime(2024, 3, 12, 4, 55, 25, 377, DateTimeKind.Local).AddTicks(3327), "2024-03-12 04:55", new TimeSpan(0, 4, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Ride",
                keyColumn: "RideId",
                keyValue: 5,
                columns: new[] { "DepartureTime", "DepartureTimeFormatted", "RideDuration" },
                values: new object[] { new DateTime(2024, 3, 12, 3, 55, 25, 377, DateTimeKind.Local).AddTicks(3331), "2024-03-12 03:55", new TimeSpan(0, 3, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Ride",
                keyColumn: "RideId",
                keyValue: 6,
                columns: new[] { "DepartureTime", "DepartureTimeFormatted", "RideDuration" },
                values: new object[] { new DateTime(2024, 3, 12, 4, 55, 25, 377, DateTimeKind.Local).AddTicks(3336), "2024-03-12 04:55", new TimeSpan(0, 4, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Ride",
                keyColumn: "RideId",
                keyValue: 7,
                columns: new[] { "DepartureTime", "DepartureTimeFormatted", "RideDuration" },
                values: new object[] { new DateTime(2024, 3, 12, 3, 55, 25, 377, DateTimeKind.Local).AddTicks(3340), "2024-03-12 03:55", new TimeSpan(0, 3, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Ride",
                keyColumn: "RideId",
                keyValue: 8,
                columns: new[] { "DepartureTime", "DepartureTimeFormatted", "RideDuration" },
                values: new object[] { new DateTime(2024, 3, 12, 4, 55, 25, 377, DateTimeKind.Local).AddTicks(3345), "2024-03-12 04:55", new TimeSpan(0, 4, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Ride",
                keyColumn: "RideId",
                keyValue: 9,
                columns: new[] { "DepartureTime", "DepartureTimeFormatted", "RideDuration" },
                values: new object[] { new DateTime(2024, 3, 12, 3, 55, 25, 377, DateTimeKind.Local).AddTicks(3349), "2024-03-12 03:55", new TimeSpan(0, 3, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Ride",
                keyColumn: "RideId",
                keyValue: 10,
                columns: new[] { "DepartureTime", "DepartureTimeFormatted", "RideDuration" },
                values: new object[] { new DateTime(2024, 3, 12, 4, 55, 25, 377, DateTimeKind.Local).AddTicks(3354), "2024-03-12 04:55", new TimeSpan(0, 4, 0, 0, 0) });
        }
    }
}
