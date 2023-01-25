using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Vidly.Migrations
{
    /// <inheritdoc />
    public partial class seedingMembershipTypeTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "MembershipType",
                columns: new[] { "Id", "DiscountRate", "DurationInMonths", "SignUpFee" },
                values: new object[,]
                {
                    { 1, (byte)0, (byte)0, (short)0 },
                    { 2, (byte)10, (byte)1, (short)30 },
                    { 3, (byte)15, (byte)3, (short)90 },
                    { 4, (byte)20, (byte)12, (short)300 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MembershipType",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MembershipType",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MembershipType",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "MembershipType",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
