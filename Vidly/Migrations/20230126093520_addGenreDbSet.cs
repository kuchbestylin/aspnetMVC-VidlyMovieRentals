using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vidly.Migrations
{
    /// <inheritdoc />
    public partial class addGenreDbSet : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.Id);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Genres");

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
    }
}
