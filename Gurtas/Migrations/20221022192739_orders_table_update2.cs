using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gurtas.Migrations
{
    public partial class orders_table_update2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Orders",
                type: "bit",
                nullable: false,
                defaultValue: false);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Orders");

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
    }
}
