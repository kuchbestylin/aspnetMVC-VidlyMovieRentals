using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Vidly.Migrations
{
    /// <inheritdoc />
    public partial class seedingMoviesTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genre", "Name", "Release", "Stock" },
                values: new object[,]
                {
                    { 1, "Romance", "A Perfect Match", new DateTime(2016, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 2, "Adventure", "Jumanji", new DateTime(2018, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 3, "Mistery", "A Resonable Doubt", new DateTime(2013, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 4, "Romance", "Brown Coffee", new DateTime(2013, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 5, "Thriller", "Most Wanted", new DateTime(2016, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 6, "Thriller", "The Maze Runner", new DateTime(2018, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 7, "Scify", "Blade Runner", new DateTime(2017, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 8, "Action", "13 Hours the Secret Soldier", new DateTime(2012, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 9, "Action", "The Matrix Ressurection", new DateTime(1994, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9);
        }
    }
}
