using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Vidly.Migrations
{
    /// <inheritdoc />
    public partial class addingGenreIdSeedAndGenreRelationToMovie : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Genre",
                table: "Movies");

            migrationBuilder.AddColumn<int>(
                name: "GenreId",
                table: "Movies",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "Mystery");

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "Romance");

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 7, "Scify" },
                    { 8, "Thriller" }
                });

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
                columns: new[] { "Added", "GenreId" },
                values: new object[] { new DateTime(2023, 1, 26, 12, 28, 5, 766, DateTimeKind.Local).AddTicks(7361), 2 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Added", "GenreId" },
                values: new object[] { new DateTime(2023, 1, 26, 12, 28, 5, 766, DateTimeKind.Local).AddTicks(7376), 6 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Added", "GenreId" },
                values: new object[] { new DateTime(2023, 1, 26, 12, 28, 5, 766, DateTimeKind.Local).AddTicks(7391), 6 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Added", "GenreId" },
                values: new object[] { new DateTime(2023, 1, 26, 12, 28, 5, 766, DateTimeKind.Local).AddTicks(7405), 1 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Added", "GenreId" },
                values: new object[] { new DateTime(2023, 1, 26, 12, 28, 5, 766, DateTimeKind.Local).AddTicks(7421), 5 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Added", "GenreId" },
                values: new object[] { new DateTime(2023, 1, 26, 12, 28, 5, 766, DateTimeKind.Local).AddTicks(7435), 7 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Added", "GenreId" },
                values: new object[] { new DateTime(2023, 1, 26, 12, 28, 5, 766, DateTimeKind.Local).AddTicks(7449), 1 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Added", "GenreId" },
                values: new object[] { new DateTime(2023, 1, 26, 12, 28, 5, 766, DateTimeKind.Local).AddTicks(7463), 1 });

            migrationBuilder.CreateIndex(
                name: "IX_Movies_GenreId",
                table: "Movies",
                column: "GenreId");

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Genres_GenreId",
                table: "Movies",
                column: "GenreId",
                principalTable: "Genres",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Genres_GenreId",
                table: "Movies");

            migrationBuilder.DropIndex(
                name: "IX_Movies_GenreId",
                table: "Movies");

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DropColumn(
                name: "GenreId",
                table: "Movies");

            migrationBuilder.AddColumn<string>(
                name: "Genre",
                table: "Movies",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "Scify");

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "Thriller");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Added", "Genre" },
                values: new object[] { new DateTime(2023, 1, 26, 12, 14, 26, 360, DateTimeKind.Local).AddTicks(8755), null });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Added", "Genre" },
                values: new object[] { new DateTime(2023, 1, 26, 12, 14, 26, 360, DateTimeKind.Local).AddTicks(8786), null });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Added", "Genre" },
                values: new object[] { new DateTime(2023, 1, 26, 12, 14, 26, 360, DateTimeKind.Local).AddTicks(8796), null });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Added", "Genre" },
                values: new object[] { new DateTime(2023, 1, 26, 12, 14, 26, 360, DateTimeKind.Local).AddTicks(8806), null });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Added", "Genre" },
                values: new object[] { new DateTime(2023, 1, 26, 12, 14, 26, 360, DateTimeKind.Local).AddTicks(8816), null });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Added", "Genre" },
                values: new object[] { new DateTime(2023, 1, 26, 12, 14, 26, 360, DateTimeKind.Local).AddTicks(8826), null });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Added", "Genre" },
                values: new object[] { new DateTime(2023, 1, 26, 12, 14, 26, 360, DateTimeKind.Local).AddTicks(8835), null });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Added", "Genre" },
                values: new object[] { new DateTime(2023, 1, 26, 12, 14, 26, 360, DateTimeKind.Local).AddTicks(8845), null });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Added", "Genre" },
                values: new object[] { new DateTime(2023, 1, 26, 12, 14, 26, 360, DateTimeKind.Local).AddTicks(8853), null });
        }
    }
}
