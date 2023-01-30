using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vidly.Migrations
{
    /// <inheritdoc />
    public partial class settingAddedforMovieModelToComputed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                column: "GenreId",
                value: 6);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Added", "GenreId" },
                values: new object[] { new DateTime(2023, 1, 26, 12, 28, 5, 766, DateTimeKind.Local).AddTicks(7320), 5 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "Added",
                value: new DateTime(2023, 1, 26, 12, 28, 5, 766, DateTimeKind.Local).AddTicks(7361));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                column: "Added",
                value: new DateTime(2023, 1, 26, 12, 28, 5, 766, DateTimeKind.Local).AddTicks(7376));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                column: "Added",
                value: new DateTime(2023, 1, 26, 12, 28, 5, 766, DateTimeKind.Local).AddTicks(7391));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                column: "Added",
                value: new DateTime(2023, 1, 26, 12, 28, 5, 766, DateTimeKind.Local).AddTicks(7405));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                column: "Added",
                value: new DateTime(2023, 1, 26, 12, 28, 5, 766, DateTimeKind.Local).AddTicks(7421));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                column: "Added",
                value: new DateTime(2023, 1, 26, 12, 28, 5, 766, DateTimeKind.Local).AddTicks(7435));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                column: "Added",
                value: new DateTime(2023, 1, 26, 12, 28, 5, 766, DateTimeKind.Local).AddTicks(7449));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                column: "Added",
                value: new DateTime(2023, 1, 26, 12, 28, 5, 766, DateTimeKind.Local).AddTicks(7463));
        }
    }
}
