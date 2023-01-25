using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vidly.Migrations
{
    /// <inheritdoc />
    public partial class addingNameAttributeToMembershipType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_customers_MembershipType_MembershipTypeId",
                table: "customers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_customers",
                table: "customers");

            migrationBuilder.RenameTable(
                name: "customers",
                newName: "Customers");

            migrationBuilder.RenameIndex(
                name: "IX_customers_MembershipTypeId",
                table: "Customers",
                newName: "IX_Customers_MembershipTypeId");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "MembershipType",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customers",
                table: "Customers",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "MembershipType",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Free");

            migrationBuilder.UpdateData(
                table: "MembershipType",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Basic");

            migrationBuilder.UpdateData(
                table: "MembershipType",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Compact");

            migrationBuilder.UpdateData(
                table: "MembershipType",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Premium");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_MembershipType_MembershipTypeId",
                table: "Customers",
                column: "MembershipTypeId",
                principalTable: "MembershipType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_MembershipType_MembershipTypeId",
                table: "Customers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Customers",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "MembershipType");

            migrationBuilder.RenameTable(
                name: "Customers",
                newName: "customers");

            migrationBuilder.RenameIndex(
                name: "IX_Customers_MembershipTypeId",
                table: "customers",
                newName: "IX_customers_MembershipTypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_customers",
                table: "customers",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_customers_MembershipType_MembershipTypeId",
                table: "customers",
                column: "MembershipTypeId",
                principalTable: "MembershipType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
