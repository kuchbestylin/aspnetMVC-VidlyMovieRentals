using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vidly.Migrations
{
    /// <inheritdoc />
    public partial class nameHasNoNullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                column: "Added",
                value: new DateTime(2023, 1, 26, 9, 27, 43, 761, DateTimeKind.Local).AddTicks(2216));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "Added",
                value: new DateTime(2023, 1, 26, 9, 27, 43, 761, DateTimeKind.Local).AddTicks(2247));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                column: "Added",
                value: new DateTime(2023, 1, 26, 9, 27, 43, 761, DateTimeKind.Local).AddTicks(2255));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                column: "Added",
                value: new DateTime(2023, 1, 26, 9, 27, 43, 761, DateTimeKind.Local).AddTicks(2263));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                column: "Added",
                value: new DateTime(2023, 1, 26, 9, 27, 43, 761, DateTimeKind.Local).AddTicks(2272));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                column: "Added",
                value: new DateTime(2023, 1, 26, 9, 27, 43, 761, DateTimeKind.Local).AddTicks(2280));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                column: "Added",
                value: new DateTime(2023, 1, 26, 9, 27, 43, 761, DateTimeKind.Local).AddTicks(2288));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                column: "Added",
                value: new DateTime(2023, 1, 26, 9, 27, 43, 761, DateTimeKind.Local).AddTicks(2299));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                column: "Added",
                value: new DateTime(2023, 1, 26, 9, 27, 43, 761, DateTimeKind.Local).AddTicks(2308));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                column: "Added",
                value: new DateTime(2023, 1, 26, 9, 16, 20, 112, DateTimeKind.Local).AddTicks(2157));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "Added",
                value: new DateTime(2023, 1, 26, 9, 16, 20, 112, DateTimeKind.Local).AddTicks(2187));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                column: "Added",
                value: new DateTime(2023, 1, 26, 9, 16, 20, 112, DateTimeKind.Local).AddTicks(2196));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                column: "Added",
                value: new DateTime(2023, 1, 26, 9, 16, 20, 112, DateTimeKind.Local).AddTicks(2205));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                column: "Added",
                value: new DateTime(2023, 1, 26, 9, 16, 20, 112, DateTimeKind.Local).AddTicks(2215));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                column: "Added",
                value: new DateTime(2023, 1, 26, 9, 16, 20, 112, DateTimeKind.Local).AddTicks(2224));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                column: "Added",
                value: new DateTime(2023, 1, 26, 9, 16, 20, 112, DateTimeKind.Local).AddTicks(2234));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                column: "Added",
                value: new DateTime(2023, 1, 26, 9, 16, 20, 112, DateTimeKind.Local).AddTicks(2243));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                column: "Added",
                value: new DateTime(2023, 1, 26, 9, 16, 20, 112, DateTimeKind.Local).AddTicks(2252));
        }
    }
}
