using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gurtas.Migrations
{
    public partial class orders_table_update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "OrderDetail",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "MeasureTools",
                keyColumn: "ToolId",
                keyValue: 1,
                columns: new[] { "ModifiedDate", "RecordDate" },
                values: new object[] { new DateTime(2022, 10, 22, 22, 18, 46, 254, DateTimeKind.Local).AddTicks(3262), new DateTime(2022, 10, 22, 22, 18, 46, 254, DateTimeKind.Local).AddTicks(3259) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "SupplierId",
                keyValue: 1,
                columns: new[] { "ModifiedDate", "RecordDate" },
                values: new object[] { new DateTime(2022, 10, 22, 22, 18, 46, 254, DateTimeKind.Local).AddTicks(8542), new DateTime(2022, 10, 22, 22, 18, 46, 254, DateTimeKind.Local).AddTicks(8539) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "ModifiedDate", "RecordDate" },
                values: new object[] { new DateTime(2022, 10, 22, 22, 18, 46, 253, DateTimeKind.Local).AddTicks(9148), new DateTime(2022, 10, 22, 22, 18, 46, 253, DateTimeKind.Local).AddTicks(9117) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "ModifiedDate", "RecordDate" },
                values: new object[] { new DateTime(2022, 10, 22, 22, 18, 46, 253, DateTimeKind.Local).AddTicks(9151), new DateTime(2022, 10, 22, 22, 18, 46, 253, DateTimeKind.Local).AddTicks(9150) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "ModifiedDate", "RecordDate" },
                values: new object[] { new DateTime(2022, 10, 22, 22, 18, 46, 253, DateTimeKind.Local).AddTicks(9153), new DateTime(2022, 10, 22, 22, 18, 46, 253, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "ModifiedDate", "RecordDate" },
                values: new object[] { new DateTime(2022, 10, 22, 22, 18, 46, 253, DateTimeKind.Local).AddTicks(9154), new DateTime(2022, 10, 22, 22, 18, 46, 253, DateTimeKind.Local).AddTicks(9154) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5,
                columns: new[] { "ModifiedDate", "RecordDate" },
                values: new object[] { new DateTime(2022, 10, 22, 22, 18, 46, 253, DateTimeKind.Local).AddTicks(9156), new DateTime(2022, 10, 22, 22, 18, 46, 253, DateTimeKind.Local).AddTicks(9155) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6,
                columns: new[] { "ModifiedDate", "RecordDate" },
                values: new object[] { new DateTime(2022, 10, 22, 22, 18, 46, 253, DateTimeKind.Local).AddTicks(9157), new DateTime(2022, 10, 22, 22, 18, 46, 253, DateTimeKind.Local).AddTicks(9157) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OrderDetail",
                table: "Orders");

            migrationBuilder.UpdateData(
                table: "MeasureTools",
                keyColumn: "ToolId",
                keyValue: 1,
                columns: new[] { "ModifiedDate", "RecordDate" },
                values: new object[] { new DateTime(2022, 10, 22, 22, 16, 6, 78, DateTimeKind.Local).AddTicks(7643), new DateTime(2022, 10, 22, 22, 16, 6, 78, DateTimeKind.Local).AddTicks(7640) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "SupplierId",
                keyValue: 1,
                columns: new[] { "ModifiedDate", "RecordDate" },
                values: new object[] { new DateTime(2022, 10, 22, 22, 16, 6, 79, DateTimeKind.Local).AddTicks(2174), new DateTime(2022, 10, 22, 22, 16, 6, 79, DateTimeKind.Local).AddTicks(2171) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "ModifiedDate", "RecordDate" },
                values: new object[] { new DateTime(2022, 10, 22, 22, 16, 6, 78, DateTimeKind.Local).AddTicks(5250), new DateTime(2022, 10, 22, 22, 16, 6, 78, DateTimeKind.Local).AddTicks(5239) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "ModifiedDate", "RecordDate" },
                values: new object[] { new DateTime(2022, 10, 22, 22, 16, 6, 78, DateTimeKind.Local).AddTicks(5253), new DateTime(2022, 10, 22, 22, 16, 6, 78, DateTimeKind.Local).AddTicks(5252) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "ModifiedDate", "RecordDate" },
                values: new object[] { new DateTime(2022, 10, 22, 22, 16, 6, 78, DateTimeKind.Local).AddTicks(5254), new DateTime(2022, 10, 22, 22, 16, 6, 78, DateTimeKind.Local).AddTicks(5254) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "ModifiedDate", "RecordDate" },
                values: new object[] { new DateTime(2022, 10, 22, 22, 16, 6, 78, DateTimeKind.Local).AddTicks(5256), new DateTime(2022, 10, 22, 22, 16, 6, 78, DateTimeKind.Local).AddTicks(5256) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5,
                columns: new[] { "ModifiedDate", "RecordDate" },
                values: new object[] { new DateTime(2022, 10, 22, 22, 16, 6, 78, DateTimeKind.Local).AddTicks(5258), new DateTime(2022, 10, 22, 22, 16, 6, 78, DateTimeKind.Local).AddTicks(5257) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6,
                columns: new[] { "ModifiedDate", "RecordDate" },
                values: new object[] { new DateTime(2022, 10, 22, 22, 16, 6, 78, DateTimeKind.Local).AddTicks(5259), new DateTime(2022, 10, 22, 22, 16, 6, 78, DateTimeKind.Local).AddTicks(5259) });
        }
    }
}
