using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 30, 21, 32, 3, 848, DateTimeKind.Local).AddTicks(8398), new DateTime(2025, 11, 30, 21, 32, 3, 848, DateTimeKind.Local).AddTicks(8415) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 30, 21, 32, 3, 848, DateTimeKind.Local).AddTicks(8417), new DateTime(2025, 11, 30, 21, 32, 3, 848, DateTimeKind.Local).AddTicks(8418) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 30, 21, 32, 3, 848, DateTimeKind.Local).AddTicks(8622), new DateTime(2025, 11, 30, 21, 32, 3, 848, DateTimeKind.Local).AddTicks(8622) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 30, 21, 32, 3, 848, DateTimeKind.Local).AddTicks(8624), new DateTime(2025, 11, 30, 21, 32, 3, 848, DateTimeKind.Local).AddTicks(8624) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 30, 21, 32, 3, 848, DateTimeKind.Local).AddTicks(8722), new DateTime(2025, 11, 30, 21, 32, 3, 848, DateTimeKind.Local).AddTicks(8722) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 30, 21, 32, 3, 848, DateTimeKind.Local).AddTicks(8723), new DateTime(2025, 11, 30, 21, 32, 3, 848, DateTimeKind.Local).AddTicks(8724) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 30, 21, 32, 3, 848, DateTimeKind.Local).AddTicks(8725), new DateTime(2025, 11, 30, 21, 32, 3, 848, DateTimeKind.Local).AddTicks(8725) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 30, 21, 32, 3, 848, DateTimeKind.Local).AddTicks(8726), new DateTime(2025, 11, 30, 21, 32, 3, 848, DateTimeKind.Local).AddTicks(8726) });
        }
    }
}
