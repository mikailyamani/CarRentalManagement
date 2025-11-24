using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colour",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 24, 11, 43, 59, 73, DateTimeKind.Local).AddTicks(8603), new DateTime(2025, 11, 24, 11, 43, 59, 73, DateTimeKind.Local).AddTicks(8622), "Black", "System" },
                    { 2, "System", new DateTime(2025, 11, 24, 11, 43, 59, 73, DateTimeKind.Local).AddTicks(8627), new DateTime(2025, 11, 24, 11, 43, 59, 73, DateTimeKind.Local).AddTicks(8628), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 24, 11, 43, 59, 73, DateTimeKind.Local).AddTicks(8906), new DateTime(2025, 11, 24, 11, 43, 59, 73, DateTimeKind.Local).AddTicks(8907), "BMW", "System" },
                    { 2, "System", new DateTime(2025, 11, 24, 11, 43, 59, 73, DateTimeKind.Local).AddTicks(8908), new DateTime(2025, 11, 24, 11, 43, 59, 73, DateTimeKind.Local).AddTicks(8909), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 24, 11, 43, 59, 73, DateTimeKind.Local).AddTicks(9044), new DateTime(2025, 11, 24, 11, 43, 59, 73, DateTimeKind.Local).AddTicks(9045), "i4", "System" },
                    { 2, "System", new DateTime(2025, 11, 24, 11, 43, 59, 73, DateTimeKind.Local).AddTicks(9047), new DateTime(2025, 11, 24, 11, 43, 59, 73, DateTimeKind.Local).AddTicks(9047), "X5", "System" },
                    { 3, "System", new DateTime(2025, 11, 24, 11, 43, 59, 73, DateTimeKind.Local).AddTicks(9049), new DateTime(2025, 11, 24, 11, 43, 59, 73, DateTimeKind.Local).AddTicks(9050), "Prius", "System" },
                    { 4, "System", new DateTime(2025, 11, 24, 11, 43, 59, 73, DateTimeKind.Local).AddTicks(9052), new DateTime(2025, 11, 24, 11, 43, 59, 73, DateTimeKind.Local).AddTicks(9052), "C-HR", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
