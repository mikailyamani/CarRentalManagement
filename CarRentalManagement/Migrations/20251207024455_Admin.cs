using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class Admin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 30, 22, 8, 56, 781, DateTimeKind.Local).AddTicks(5574), new DateTime(2025, 11, 30, 22, 8, 56, 781, DateTimeKind.Local).AddTicks(5608) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 30, 22, 8, 56, 781, DateTimeKind.Local).AddTicks(5613), new DateTime(2025, 11, 30, 22, 8, 56, 781, DateTimeKind.Local).AddTicks(5614) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 30, 22, 8, 56, 781, DateTimeKind.Local).AddTicks(5866), new DateTime(2025, 11, 30, 22, 8, 56, 781, DateTimeKind.Local).AddTicks(5866) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 30, 22, 8, 56, 781, DateTimeKind.Local).AddTicks(5867), new DateTime(2025, 11, 30, 22, 8, 56, 781, DateTimeKind.Local).AddTicks(5868) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 30, 22, 8, 56, 781, DateTimeKind.Local).AddTicks(5982), new DateTime(2025, 11, 30, 22, 8, 56, 781, DateTimeKind.Local).AddTicks(5982) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 30, 22, 8, 56, 781, DateTimeKind.Local).AddTicks(5983), new DateTime(2025, 11, 30, 22, 8, 56, 781, DateTimeKind.Local).AddTicks(5984) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 30, 22, 8, 56, 781, DateTimeKind.Local).AddTicks(5985), new DateTime(2025, 11, 30, 22, 8, 56, 781, DateTimeKind.Local).AddTicks(5985) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 30, 22, 8, 56, 781, DateTimeKind.Local).AddTicks(5986), new DateTime(2025, 11, 30, 22, 8, 56, 781, DateTimeKind.Local).AddTicks(5987) });
        }
    }
}
