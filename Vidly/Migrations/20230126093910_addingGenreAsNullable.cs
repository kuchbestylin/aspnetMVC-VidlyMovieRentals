using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vidly.Migrations
{
    /// <inheritdoc />
    public partial class addingGenreAsNullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Genre",
                table: "Movies",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                column: "Added",
                value: new DateTime(2023, 1, 26, 11, 39, 10, 105, DateTimeKind.Local).AddTicks(6615));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "Added",
                value: new DateTime(2023, 1, 26, 11, 39, 10, 105, DateTimeKind.Local).AddTicks(6646));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                column: "Added",
                value: new DateTime(2023, 1, 26, 11, 39, 10, 105, DateTimeKind.Local).AddTicks(6656));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                column: "Added",
                value: new DateTime(2023, 1, 26, 11, 39, 10, 105, DateTimeKind.Local).AddTicks(6665));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                column: "Added",
                value: new DateTime(2023, 1, 26, 11, 39, 10, 105, DateTimeKind.Local).AddTicks(6675));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                column: "Added",
                value: new DateTime(2023, 1, 26, 11, 39, 10, 105, DateTimeKind.Local).AddTicks(6685));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                column: "Added",
                value: new DateTime(2023, 1, 26, 11, 39, 10, 105, DateTimeKind.Local).AddTicks(6694));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                column: "Added",
                value: new DateTime(2023, 1, 26, 11, 39, 10, 105, DateTimeKind.Local).AddTicks(6704));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                column: "Added",
                value: new DateTime(2023, 1, 26, 11, 39, 10, 105, DateTimeKind.Local).AddTicks(6713));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Genre",
                table: "Movies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                column: "Added",
                value: new DateTime(2023, 1, 26, 11, 35, 19, 785, DateTimeKind.Local).AddTicks(4295));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "Added",
                value: new DateTime(2023, 1, 26, 11, 35, 19, 785, DateTimeKind.Local).AddTicks(4337));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                column: "Added",
                value: new DateTime(2023, 1, 26, 11, 35, 19, 785, DateTimeKind.Local).AddTicks(4352));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                column: "Added",
                value: new DateTime(2023, 1, 26, 11, 35, 19, 785, DateTimeKind.Local).AddTicks(4367));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                column: "Added",
                value: new DateTime(2023, 1, 26, 11, 35, 19, 785, DateTimeKind.Local).AddTicks(4382));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                column: "Added",
                value: new DateTime(2023, 1, 26, 11, 35, 19, 785, DateTimeKind.Local).AddTicks(4397));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                column: "Added",
                value: new DateTime(2023, 1, 26, 11, 35, 19, 785, DateTimeKind.Local).AddTicks(4412));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                column: "Added",
                value: new DateTime(2023, 1, 26, 11, 35, 19, 785, DateTimeKind.Local).AddTicks(4427));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                column: "Added",
                value: new DateTime(2023, 1, 26, 11, 35, 19, 785, DateTimeKind.Local).AddTicks(4441));
        }
    }
}
