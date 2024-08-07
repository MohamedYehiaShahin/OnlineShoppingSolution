using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataLayer.Migrations
{
    /// <inheritdoc />
    public partial class RolesSeeded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2b37d5bf-d108-404a-a071-7cbc94ab28e9", "3", "Seller", "Seller" },
                    { "932e4fc8-565a-4160-a617-2d82a2dbeb6e", "4", "Both", "Both" },
                    { "a3d56aba-9e78-4010-b710-250387931e2e", "2", "Buyer", "Buyer" },
                    { "b4b4233e-3aff-4e73-b81e-70a7ea0647b7", "1", "Admin", "Admin" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2b37d5bf-d108-404a-a071-7cbc94ab28e9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "932e4fc8-565a-4160-a617-2d82a2dbeb6e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a3d56aba-9e78-4010-b710-250387931e2e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b4b4233e-3aff-4e73-b81e-70a7ea0647b7");
        }
    }
}
