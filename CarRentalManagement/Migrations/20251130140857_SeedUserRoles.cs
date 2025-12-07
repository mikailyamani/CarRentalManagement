using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 30, 22, 2, 21, 691, DateTimeKind.Local).AddTicks(3619), new DateTime(2025, 11, 30, 22, 2, 21, 691, DateTimeKind.Local).AddTicks(3638) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 30, 22, 2, 21, 691, DateTimeKind.Local).AddTicks(3641), new DateTime(2025, 11, 30, 22, 2, 21, 691, DateTimeKind.Local).AddTicks(3641) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 30, 22, 2, 21, 691, DateTimeKind.Local).AddTicks(3830), new DateTime(2025, 11, 30, 22, 2, 21, 691, DateTimeKind.Local).AddTicks(3830) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 30, 22, 2, 21, 691, DateTimeKind.Local).AddTicks(3832), new DateTime(2025, 11, 30, 22, 2, 21, 691, DateTimeKind.Local).AddTicks(3832) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 30, 22, 2, 21, 691, DateTimeKind.Local).AddTicks(3917), new DateTime(2025, 11, 30, 22, 2, 21, 691, DateTimeKind.Local).AddTicks(3918) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 30, 22, 2, 21, 691, DateTimeKind.Local).AddTicks(3919), new DateTime(2025, 11, 30, 22, 2, 21, 691, DateTimeKind.Local).AddTicks(3919) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 30, 22, 2, 21, 691, DateTimeKind.Local).AddTicks(3920), new DateTime(2025, 11, 30, 22, 2, 21, 691, DateTimeKind.Local).AddTicks(3920) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 30, 22, 2, 21, 691, DateTimeKind.Local).AddTicks(3921), new DateTime(2025, 11, 30, 22, 2, 21, 691, DateTimeKind.Local).AddTicks(3922) });
        }
    }
}
