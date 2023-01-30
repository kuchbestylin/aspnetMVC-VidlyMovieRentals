using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vidly.Migrations
{
    /// <inheritdoc />
    public partial class removingGenreValuesFromSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Added", "Genre" },
                values: new object[] { new DateTime(2023, 1, 26, 11, 42, 6, 678, DateTimeKind.Local).AddTicks(7054), null });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Added", "Genre" },
                values: new object[] { new DateTime(2023, 1, 26, 11, 42, 6, 678, DateTimeKind.Local).AddTicks(7208), null });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Added", "Genre" },
                values: new object[] { new DateTime(2023, 1, 26, 11, 42, 6, 678, DateTimeKind.Local).AddTicks(7228), null });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Added", "Genre" },
                values: new object[] { new DateTime(2023, 1, 26, 11, 42, 6, 678, DateTimeKind.Local).AddTicks(7242), null });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Added", "Genre" },
                values: new object[] { new DateTime(2023, 1, 26, 11, 42, 6, 678, DateTimeKind.Local).AddTicks(7258), null });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Added", "Genre" },
                values: new object[] { new DateTime(2023, 1, 26, 11, 42, 6, 678, DateTimeKind.Local).AddTicks(7272), null });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Added", "Genre" },
                values: new object[] { new DateTime(2023, 1, 26, 11, 42, 6, 678, DateTimeKind.Local).AddTicks(7287), null });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Added", "Genre" },
                values: new object[] { new DateTime(2023, 1, 26, 11, 42, 6, 678, DateTimeKind.Local).AddTicks(7302), null });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Added", "Genre" },
                values: new object[] { new DateTime(2023, 1, 26, 11, 42, 6, 678, DateTimeKind.Local).AddTicks(7316), null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Added", "Genre" },
                values: new object[] { new DateTime(2023, 1, 26, 11, 39, 10, 105, DateTimeKind.Local).AddTicks(6615), "Romance" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Added", "Genre" },
                values: new object[] { new DateTime(2023, 1, 26, 11, 39, 10, 105, DateTimeKind.Local).AddTicks(6646), "Adventure" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Added", "Genre" },
                values: new object[] { new DateTime(2023, 1, 26, 11, 39, 10, 105, DateTimeKind.Local).AddTicks(6656), "Mistery" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Added", "Genre" },
                values: new object[] { new DateTime(2023, 1, 26, 11, 39, 10, 105, DateTimeKind.Local).AddTicks(6665), "Romance" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Added", "Genre" },
                values: new object[] { new DateTime(2023, 1, 26, 11, 39, 10, 105, DateTimeKind.Local).AddTicks(6675), "Thriller" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Added", "Genre" },
                values: new object[] { new DateTime(2023, 1, 26, 11, 39, 10, 105, DateTimeKind.Local).AddTicks(6685), "Thriller" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Added", "Genre" },
                values: new object[] { new DateTime(2023, 1, 26, 11, 39, 10, 105, DateTimeKind.Local).AddTicks(6694), "Scify" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Added", "Genre" },
                values: new object[] { new DateTime(2023, 1, 26, 11, 39, 10, 105, DateTimeKind.Local).AddTicks(6704), "Action" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Added", "Genre" },
                values: new object[] { new DateTime(2023, 1, 26, 11, 39, 10, 105, DateTimeKind.Local).AddTicks(6713), "Action" });
        }
    }
}
