﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vidly.Migrations
{
    /// <inheritdoc />
    public partial class removingNullableFromName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                column: "Added",
                value: new DateTime(2023, 1, 26, 9, 13, 13, 72, DateTimeKind.Local).AddTicks(2167));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "Added",
                value: new DateTime(2023, 1, 26, 9, 13, 13, 72, DateTimeKind.Local).AddTicks(2205));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                column: "Added",
                value: new DateTime(2023, 1, 26, 9, 13, 13, 72, DateTimeKind.Local).AddTicks(2221));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                column: "Added",
                value: new DateTime(2023, 1, 26, 9, 13, 13, 72, DateTimeKind.Local).AddTicks(2236));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                column: "Added",
                value: new DateTime(2023, 1, 26, 9, 13, 13, 72, DateTimeKind.Local).AddTicks(2251));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                column: "Added",
                value: new DateTime(2023, 1, 26, 9, 13, 13, 72, DateTimeKind.Local).AddTicks(2266));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                column: "Added",
                value: new DateTime(2023, 1, 26, 9, 13, 13, 72, DateTimeKind.Local).AddTicks(2283));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                column: "Added",
                value: new DateTime(2023, 1, 26, 9, 13, 13, 72, DateTimeKind.Local).AddTicks(2297));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                column: "Added",
                value: new DateTime(2023, 1, 26, 9, 13, 13, 72, DateTimeKind.Local).AddTicks(2311));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                column: "Added",
                value: new DateTime(2023, 1, 26, 9, 10, 6, 540, DateTimeKind.Local).AddTicks(6793));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "Added",
                value: new DateTime(2023, 1, 26, 9, 10, 6, 540, DateTimeKind.Local).AddTicks(6823));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                column: "Added",
                value: new DateTime(2023, 1, 26, 9, 10, 6, 540, DateTimeKind.Local).AddTicks(6834));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                column: "Added",
                value: new DateTime(2023, 1, 26, 9, 10, 6, 540, DateTimeKind.Local).AddTicks(6843));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                column: "Added",
                value: new DateTime(2023, 1, 26, 9, 10, 6, 540, DateTimeKind.Local).AddTicks(6852));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                column: "Added",
                value: new DateTime(2023, 1, 26, 9, 10, 6, 540, DateTimeKind.Local).AddTicks(6862));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                column: "Added",
                value: new DateTime(2023, 1, 26, 9, 10, 6, 540, DateTimeKind.Local).AddTicks(6871));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                column: "Added",
                value: new DateTime(2023, 1, 26, 9, 10, 6, 540, DateTimeKind.Local).AddTicks(6880));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                column: "Added",
                value: new DateTime(2023, 1, 26, 9, 10, 6, 540, DateTimeKind.Local).AddTicks(6889));
        }
    }
}
