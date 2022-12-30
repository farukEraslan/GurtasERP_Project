using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gurtas.Migrations
{
    public partial class input_control_add_update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "MeasureTools",
                keyColumn: "ToolId",
                keyValue: 1,
                columns: new[] { "ModifiedDate", "RecordDate" },
                values: new object[] { new DateTime(2022, 10, 26, 0, 11, 25, 605, DateTimeKind.Local).AddTicks(2147), new DateTime(2022, 10, 26, 0, 11, 25, 605, DateTimeKind.Local).AddTicks(2145) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "SupplierId",
                keyValue: 1,
                columns: new[] { "ModifiedDate", "RecordDate" },
                values: new object[] { new DateTime(2022, 10, 26, 0, 11, 25, 605, DateTimeKind.Local).AddTicks(7891), new DateTime(2022, 10, 26, 0, 11, 25, 605, DateTimeKind.Local).AddTicks(7885) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "ModifiedDate", "RecordDate" },
                values: new object[] { new DateTime(2022, 10, 26, 0, 11, 25, 604, DateTimeKind.Local).AddTicks(9866), new DateTime(2022, 10, 26, 0, 11, 25, 604, DateTimeKind.Local).AddTicks(9854) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "ModifiedDate", "RecordDate" },
                values: new object[] { new DateTime(2022, 10, 26, 0, 11, 25, 604, DateTimeKind.Local).AddTicks(9868), new DateTime(2022, 10, 26, 0, 11, 25, 604, DateTimeKind.Local).AddTicks(9868) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "ModifiedDate", "RecordDate" },
                values: new object[] { new DateTime(2022, 10, 26, 0, 11, 25, 604, DateTimeKind.Local).AddTicks(9870), new DateTime(2022, 10, 26, 0, 11, 25, 604, DateTimeKind.Local).AddTicks(9869) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "ModifiedDate", "RecordDate" },
                values: new object[] { new DateTime(2022, 10, 26, 0, 11, 25, 604, DateTimeKind.Local).AddTicks(9872), new DateTime(2022, 10, 26, 0, 11, 25, 604, DateTimeKind.Local).AddTicks(9871) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5,
                columns: new[] { "ModifiedDate", "RecordDate" },
                values: new object[] { new DateTime(2022, 10, 26, 0, 11, 25, 604, DateTimeKind.Local).AddTicks(9873), new DateTime(2022, 10, 26, 0, 11, 25, 604, DateTimeKind.Local).AddTicks(9873) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6,
                columns: new[] { "ModifiedDate", "RecordDate" },
                values: new object[] { new DateTime(2022, 10, 26, 0, 11, 25, 604, DateTimeKind.Local).AddTicks(9875), new DateTime(2022, 10, 26, 0, 11, 25, 604, DateTimeKind.Local).AddTicks(9874) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
