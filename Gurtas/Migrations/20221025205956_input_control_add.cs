using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gurtas.Migrations
{
    public partial class input_control_add : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "MeasureTools",
                keyColumn: "ToolId",
                keyValue: 1,
                columns: new[] { "ModifiedDate", "RecordDate" },
                values: new object[] { new DateTime(2022, 10, 25, 23, 59, 55, 996, DateTimeKind.Local).AddTicks(7901), new DateTime(2022, 10, 25, 23, 59, 55, 996, DateTimeKind.Local).AddTicks(7899) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "SupplierId",
                keyValue: 1,
                columns: new[] { "ModifiedDate", "RecordDate" },
                values: new object[] { new DateTime(2022, 10, 25, 23, 59, 55, 997, DateTimeKind.Local).AddTicks(4834), new DateTime(2022, 10, 25, 23, 59, 55, 997, DateTimeKind.Local).AddTicks(4830) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "ModifiedDate", "RecordDate" },
                values: new object[] { new DateTime(2022, 10, 25, 23, 59, 55, 996, DateTimeKind.Local).AddTicks(5428), new DateTime(2022, 10, 25, 23, 59, 55, 996, DateTimeKind.Local).AddTicks(5417) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "ModifiedDate", "RecordDate" },
                values: new object[] { new DateTime(2022, 10, 25, 23, 59, 55, 996, DateTimeKind.Local).AddTicks(5431), new DateTime(2022, 10, 25, 23, 59, 55, 996, DateTimeKind.Local).AddTicks(5430) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "ModifiedDate", "RecordDate" },
                values: new object[] { new DateTime(2022, 10, 25, 23, 59, 55, 996, DateTimeKind.Local).AddTicks(5433), new DateTime(2022, 10, 25, 23, 59, 55, 996, DateTimeKind.Local).AddTicks(5432) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "ModifiedDate", "RecordDate" },
                values: new object[] { new DateTime(2022, 10, 25, 23, 59, 55, 996, DateTimeKind.Local).AddTicks(5435), new DateTime(2022, 10, 25, 23, 59, 55, 996, DateTimeKind.Local).AddTicks(5434) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5,
                columns: new[] { "ModifiedDate", "RecordDate" },
                values: new object[] { new DateTime(2022, 10, 25, 23, 59, 55, 996, DateTimeKind.Local).AddTicks(5436), new DateTime(2022, 10, 25, 23, 59, 55, 996, DateTimeKind.Local).AddTicks(5436) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6,
                columns: new[] { "ModifiedDate", "RecordDate" },
                values: new object[] { new DateTime(2022, 10, 25, 23, 59, 55, 996, DateTimeKind.Local).AddTicks(5438), new DateTime(2022, 10, 25, 23, 59, 55, 996, DateTimeKind.Local).AddTicks(5437) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
