using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class AddedRolesAndUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "9ecf4997-4aec-4614-81a9-70eb890ea3b2", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEBdzzCCcp8ZFbPFjRDckisQdjrHWZycTdM+9rgmoswjku+5G0J0JUJEDUlU3ll2BAA==", null, false, "8fdee125-343e-4236-82b2-36a8e7124432", false, "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 7, 11, 5, 50, 902, DateTimeKind.Local).AddTicks(1561), new DateTime(2025, 12, 7, 11, 5, 50, 902, DateTimeKind.Local).AddTicks(1582) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 7, 11, 5, 50, 902, DateTimeKind.Local).AddTicks(1586), new DateTime(2025, 12, 7, 11, 5, 50, 902, DateTimeKind.Local).AddTicks(1587) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 7, 11, 5, 50, 902, DateTimeKind.Local).AddTicks(1916), new DateTime(2025, 12, 7, 11, 5, 50, 902, DateTimeKind.Local).AddTicks(1917) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 7, 11, 5, 50, 902, DateTimeKind.Local).AddTicks(1999), new DateTime(2025, 12, 7, 11, 5, 50, 902, DateTimeKind.Local).AddTicks(2000) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 7, 11, 5, 50, 902, DateTimeKind.Local).AddTicks(2197), new DateTime(2025, 12, 7, 11, 5, 50, 902, DateTimeKind.Local).AddTicks(2198) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 7, 11, 5, 50, 902, DateTimeKind.Local).AddTicks(2200), new DateTime(2025, 12, 7, 11, 5, 50, 902, DateTimeKind.Local).AddTicks(2201) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 7, 11, 5, 50, 902, DateTimeKind.Local).AddTicks(2203), new DateTime(2025, 12, 7, 11, 5, 50, 902, DateTimeKind.Local).AddTicks(2204) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 7, 11, 5, 50, 902, DateTimeKind.Local).AddTicks(2206), new DateTime(2025, 12, 7, 11, 5, 50, 902, DateTimeKind.Local).AddTicks(2207) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 7, 10, 44, 54, 281, DateTimeKind.Local).AddTicks(3114), new DateTime(2025, 12, 7, 10, 44, 54, 281, DateTimeKind.Local).AddTicks(3139) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 7, 10, 44, 54, 281, DateTimeKind.Local).AddTicks(3143), new DateTime(2025, 12, 7, 10, 44, 54, 281, DateTimeKind.Local).AddTicks(3144) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 7, 10, 44, 54, 281, DateTimeKind.Local).AddTicks(3683), new DateTime(2025, 12, 7, 10, 44, 54, 281, DateTimeKind.Local).AddTicks(3685) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 7, 10, 44, 54, 281, DateTimeKind.Local).AddTicks(3689), new DateTime(2025, 12, 7, 10, 44, 54, 281, DateTimeKind.Local).AddTicks(3690) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 7, 10, 44, 54, 281, DateTimeKind.Local).AddTicks(3978), new DateTime(2025, 12, 7, 10, 44, 54, 281, DateTimeKind.Local).AddTicks(3980) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 7, 10, 44, 54, 281, DateTimeKind.Local).AddTicks(3983), new DateTime(2025, 12, 7, 10, 44, 54, 281, DateTimeKind.Local).AddTicks(3985) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 7, 10, 44, 54, 281, DateTimeKind.Local).AddTicks(3988), new DateTime(2025, 12, 7, 10, 44, 54, 281, DateTimeKind.Local).AddTicks(3990) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 7, 10, 44, 54, 281, DateTimeKind.Local).AddTicks(3993), new DateTime(2025, 12, 7, 10, 44, 54, 281, DateTimeKind.Local).AddTicks(3994) });
        }
    }
}
