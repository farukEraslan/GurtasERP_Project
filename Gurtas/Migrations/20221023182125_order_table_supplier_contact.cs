using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gurtas.Migrations
{
    public partial class order_table_supplier_contact : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ContactName",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Supplier",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "MeasureTools",
                keyColumn: "ToolId",
                keyValue: 1,
                columns: new[] { "ModifiedDate", "RecordDate" },
                values: new object[] { new DateTime(2022, 10, 23, 21, 21, 25, 465, DateTimeKind.Local).AddTicks(2737), new DateTime(2022, 10, 23, 21, 21, 25, 465, DateTimeKind.Local).AddTicks(2734) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "SupplierId",
                keyValue: 1,
                columns: new[] { "ModifiedDate", "RecordDate" },
                values: new object[] { new DateTime(2022, 10, 23, 21, 21, 25, 466, DateTimeKind.Local).AddTicks(176), new DateTime(2022, 10, 23, 21, 21, 25, 466, DateTimeKind.Local).AddTicks(172) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "ModifiedDate", "RecordDate" },
                values: new object[] { new DateTime(2022, 10, 23, 21, 21, 25, 465, DateTimeKind.Local).AddTicks(409), new DateTime(2022, 10, 23, 21, 21, 25, 465, DateTimeKind.Local).AddTicks(398) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "ModifiedDate", "RecordDate" },
                values: new object[] { new DateTime(2022, 10, 23, 21, 21, 25, 465, DateTimeKind.Local).AddTicks(411), new DateTime(2022, 10, 23, 21, 21, 25, 465, DateTimeKind.Local).AddTicks(411) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "ModifiedDate", "RecordDate" },
                values: new object[] { new DateTime(2022, 10, 23, 21, 21, 25, 465, DateTimeKind.Local).AddTicks(413), new DateTime(2022, 10, 23, 21, 21, 25, 465, DateTimeKind.Local).AddTicks(412) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "ModifiedDate", "RecordDate" },
                values: new object[] { new DateTime(2022, 10, 23, 21, 21, 25, 465, DateTimeKind.Local).AddTicks(414), new DateTime(2022, 10, 23, 21, 21, 25, 465, DateTimeKind.Local).AddTicks(414) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5,
                columns: new[] { "ModifiedDate", "RecordDate" },
                values: new object[] { new DateTime(2022, 10, 23, 21, 21, 25, 465, DateTimeKind.Local).AddTicks(416), new DateTime(2022, 10, 23, 21, 21, 25, 465, DateTimeKind.Local).AddTicks(416) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6,
                columns: new[] { "ModifiedDate", "RecordDate" },
                values: new object[] { new DateTime(2022, 10, 23, 21, 21, 25, 465, DateTimeKind.Local).AddTicks(418), new DateTime(2022, 10, 23, 21, 21, 25, 465, DateTimeKind.Local).AddTicks(417) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ContactName",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Supplier",
                table: "Orders");

            migrationBuilder.UpdateData(
                table: "MeasureTools",
                keyColumn: "ToolId",
                keyValue: 1,
                columns: new[] { "ModifiedDate", "RecordDate" },
                values: new object[] { new DateTime(2022, 10, 23, 20, 54, 31, 972, DateTimeKind.Local).AddTicks(14), new DateTime(2022, 10, 23, 20, 54, 31, 972, DateTimeKind.Local).AddTicks(12) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "SupplierId",
                keyValue: 1,
                columns: new[] { "ModifiedDate", "RecordDate" },
                values: new object[] { new DateTime(2022, 10, 23, 20, 54, 31, 972, DateTimeKind.Local).AddTicks(5018), new DateTime(2022, 10, 23, 20, 54, 31, 972, DateTimeKind.Local).AddTicks(4851) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "ModifiedDate", "RecordDate" },
                values: new object[] { new DateTime(2022, 10, 23, 20, 54, 31, 971, DateTimeKind.Local).AddTicks(7535), new DateTime(2022, 10, 23, 20, 54, 31, 971, DateTimeKind.Local).AddTicks(7525) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "ModifiedDate", "RecordDate" },
                values: new object[] { new DateTime(2022, 10, 23, 20, 54, 31, 971, DateTimeKind.Local).AddTicks(7538), new DateTime(2022, 10, 23, 20, 54, 31, 971, DateTimeKind.Local).AddTicks(7538) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "ModifiedDate", "RecordDate" },
                values: new object[] { new DateTime(2022, 10, 23, 20, 54, 31, 971, DateTimeKind.Local).AddTicks(7540), new DateTime(2022, 10, 23, 20, 54, 31, 971, DateTimeKind.Local).AddTicks(7540) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "ModifiedDate", "RecordDate" },
                values: new object[] { new DateTime(2022, 10, 23, 20, 54, 31, 971, DateTimeKind.Local).AddTicks(7542), new DateTime(2022, 10, 23, 20, 54, 31, 971, DateTimeKind.Local).AddTicks(7541) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5,
                columns: new[] { "ModifiedDate", "RecordDate" },
                values: new object[] { new DateTime(2022, 10, 23, 20, 54, 31, 971, DateTimeKind.Local).AddTicks(7543), new DateTime(2022, 10, 23, 20, 54, 31, 971, DateTimeKind.Local).AddTicks(7543) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6,
                columns: new[] { "ModifiedDate", "RecordDate" },
                values: new object[] { new DateTime(2022, 10, 23, 20, 54, 31, 971, DateTimeKind.Local).AddTicks(7545), new DateTime(2022, 10, 23, 20, 54, 31, 971, DateTimeKind.Local).AddTicks(7544) });
        }
    }
}
