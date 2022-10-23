using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gurtas.Migrations
{
    public partial class order_table_currency_add : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Currency",
                table: "Orders",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Currency",
                table: "Orders");

            migrationBuilder.UpdateData(
                table: "MeasureTools",
                keyColumn: "ToolId",
                keyValue: 1,
                columns: new[] { "ModifiedDate", "RecordDate" },
                values: new object[] { new DateTime(2022, 10, 22, 22, 27, 38, 892, DateTimeKind.Local).AddTicks(1678), new DateTime(2022, 10, 22, 22, 27, 38, 892, DateTimeKind.Local).AddTicks(1675) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "SupplierId",
                keyValue: 1,
                columns: new[] { "ModifiedDate", "RecordDate" },
                values: new object[] { new DateTime(2022, 10, 22, 22, 27, 38, 892, DateTimeKind.Local).AddTicks(7214), new DateTime(2022, 10, 22, 22, 27, 38, 892, DateTimeKind.Local).AddTicks(7211) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "ModifiedDate", "RecordDate" },
                values: new object[] { new DateTime(2022, 10, 22, 22, 27, 38, 891, DateTimeKind.Local).AddTicks(7809), new DateTime(2022, 10, 22, 22, 27, 38, 891, DateTimeKind.Local).AddTicks(7798) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "ModifiedDate", "RecordDate" },
                values: new object[] { new DateTime(2022, 10, 22, 22, 27, 38, 891, DateTimeKind.Local).AddTicks(7812), new DateTime(2022, 10, 22, 22, 27, 38, 891, DateTimeKind.Local).AddTicks(7812) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "ModifiedDate", "RecordDate" },
                values: new object[] { new DateTime(2022, 10, 22, 22, 27, 38, 891, DateTimeKind.Local).AddTicks(7814), new DateTime(2022, 10, 22, 22, 27, 38, 891, DateTimeKind.Local).AddTicks(7814) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "ModifiedDate", "RecordDate" },
                values: new object[] { new DateTime(2022, 10, 22, 22, 27, 38, 891, DateTimeKind.Local).AddTicks(7816), new DateTime(2022, 10, 22, 22, 27, 38, 891, DateTimeKind.Local).AddTicks(7815) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5,
                columns: new[] { "ModifiedDate", "RecordDate" },
                values: new object[] { new DateTime(2022, 10, 22, 22, 27, 38, 891, DateTimeKind.Local).AddTicks(7817), new DateTime(2022, 10, 22, 22, 27, 38, 891, DateTimeKind.Local).AddTicks(7817) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6,
                columns: new[] { "ModifiedDate", "RecordDate" },
                values: new object[] { new DateTime(2022, 10, 22, 22, 27, 38, 891, DateTimeKind.Local).AddTicks(7819), new DateTime(2022, 10, 22, 22, 27, 38, 891, DateTimeKind.Local).AddTicks(7818) });
        }
    }
}
