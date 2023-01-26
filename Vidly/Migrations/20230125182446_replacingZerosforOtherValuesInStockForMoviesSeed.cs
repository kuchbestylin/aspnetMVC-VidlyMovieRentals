using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vidly.Migrations
{
    /// <inheritdoc />
    public partial class replacingZerosforOtherValuesInStockForMoviesSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Added", "Stock" },
                values: new object[] { new DateTime(2023, 1, 25, 20, 24, 45, 694, DateTimeKind.Local).AddTicks(4303), 5 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Added", "Stock" },
                values: new object[] { new DateTime(2023, 1, 25, 20, 24, 45, 694, DateTimeKind.Local).AddTicks(4336), 4 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Added", "Stock" },
                values: new object[] { new DateTime(2023, 1, 25, 20, 24, 45, 694, DateTimeKind.Local).AddTicks(4346), 55 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Added", "Stock" },
                values: new object[] { new DateTime(2023, 1, 25, 20, 24, 45, 694, DateTimeKind.Local).AddTicks(4355), 6 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Added", "Stock" },
                values: new object[] { new DateTime(2023, 1, 25, 20, 24, 45, 694, DateTimeKind.Local).AddTicks(4364), 18 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Added", "Stock" },
                values: new object[] { new DateTime(2023, 1, 25, 20, 24, 45, 694, DateTimeKind.Local).AddTicks(4373), 34 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Added", "Stock" },
                values: new object[] { new DateTime(2023, 1, 25, 20, 24, 45, 694, DateTimeKind.Local).AddTicks(4382), 68 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Added", "Stock" },
                values: new object[] { new DateTime(2023, 1, 25, 20, 24, 45, 694, DateTimeKind.Local).AddTicks(4392), 6 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Added", "Stock" },
                values: new object[] { new DateTime(2023, 1, 25, 20, 24, 45, 694, DateTimeKind.Local).AddTicks(4401), 3 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Added", "Stock" },
                values: new object[] { new DateTime(2023, 1, 25, 20, 19, 55, 395, DateTimeKind.Local).AddTicks(7988), 0 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Added", "Stock" },
                values: new object[] { new DateTime(2023, 1, 25, 20, 19, 55, 395, DateTimeKind.Local).AddTicks(8031), 0 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Added", "Stock" },
                values: new object[] { new DateTime(2023, 1, 25, 20, 19, 55, 395, DateTimeKind.Local).AddTicks(8049), 0 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Added", "Stock" },
                values: new object[] { new DateTime(2023, 1, 25, 20, 19, 55, 395, DateTimeKind.Local).AddTicks(8064), 0 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Added", "Stock" },
                values: new object[] { new DateTime(2023, 1, 25, 20, 19, 55, 395, DateTimeKind.Local).AddTicks(8078), 0 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Added", "Stock" },
                values: new object[] { new DateTime(2023, 1, 25, 20, 19, 55, 395, DateTimeKind.Local).AddTicks(8092), 0 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Added", "Stock" },
                values: new object[] { new DateTime(2023, 1, 25, 20, 19, 55, 395, DateTimeKind.Local).AddTicks(8107), 0 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Added", "Stock" },
                values: new object[] { new DateTime(2023, 1, 25, 20, 19, 55, 395, DateTimeKind.Local).AddTicks(8122), 0 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Added", "Stock" },
                values: new object[] { new DateTime(2023, 1, 25, 20, 19, 55, 395, DateTimeKind.Local).AddTicks(8137), 0 });
        }
    }
}
