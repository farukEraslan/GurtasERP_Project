using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gurtas.Migrations
{
    public partial class seed_measureTool_data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "MeasureTools",
                columns: new[] { "ToolId", "Accuracy", "CalibrationDate", "CertificateNumber", "Manufacturer", "MeasureRange", "Model", "ModifiedDate", "NextCalibrationDate", "RecordDate", "SerialNumber", "ToolName", "Type", "UserId" },
                values: new object[] { 1, "0,01", new DateTime(2022, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "22-4791", "Mitutoyo", "0-150", "", new DateTime(2022, 10, 21, 13, 48, 46, 976, DateTimeKind.Local).AddTicks(7), new DateTime(2023, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 21, 13, 48, 46, 975, DateTimeKind.Local).AddTicks(9998), "B22084436", "Kumpas", "Dijital", 1 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "ModifiedDate", "RecordDate" },
                values: new object[] { new DateTime(2022, 10, 21, 13, 48, 46, 975, DateTimeKind.Local).AddTicks(2412), new DateTime(2022, 10, 21, 13, 48, 46, 975, DateTimeKind.Local).AddTicks(2391) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "ModifiedDate", "RecordDate" },
                values: new object[] { new DateTime(2022, 10, 21, 13, 48, 46, 975, DateTimeKind.Local).AddTicks(2420), new DateTime(2022, 10, 21, 13, 48, 46, 975, DateTimeKind.Local).AddTicks(2419) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "ModifiedDate", "RecordDate" },
                values: new object[] { new DateTime(2022, 10, 21, 13, 48, 46, 975, DateTimeKind.Local).AddTicks(2426), new DateTime(2022, 10, 21, 13, 48, 46, 975, DateTimeKind.Local).AddTicks(2425) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "ModifiedDate", "RecordDate" },
                values: new object[] { new DateTime(2022, 10, 21, 13, 48, 46, 975, DateTimeKind.Local).AddTicks(2431), new DateTime(2022, 10, 21, 13, 48, 46, 975, DateTimeKind.Local).AddTicks(2429) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5,
                columns: new[] { "ModifiedDate", "RecordDate" },
                values: new object[] { new DateTime(2022, 10, 21, 13, 48, 46, 975, DateTimeKind.Local).AddTicks(2436), new DateTime(2022, 10, 21, 13, 48, 46, 975, DateTimeKind.Local).AddTicks(2434) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6,
                columns: new[] { "ModifiedDate", "RecordDate" },
                values: new object[] { new DateTime(2022, 10, 21, 13, 48, 46, 975, DateTimeKind.Local).AddTicks(2441), new DateTime(2022, 10, 21, 13, 48, 46, 975, DateTimeKind.Local).AddTicks(2439) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MeasureTools",
                keyColumn: "ToolId",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "ModifiedDate", "RecordDate" },
                values: new object[] { new DateTime(2022, 10, 20, 17, 38, 20, 495, DateTimeKind.Local).AddTicks(3294), new DateTime(2022, 10, 20, 17, 38, 20, 495, DateTimeKind.Local).AddTicks(3281) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "ModifiedDate", "RecordDate" },
                values: new object[] { new DateTime(2022, 10, 20, 17, 38, 20, 495, DateTimeKind.Local).AddTicks(3298), new DateTime(2022, 10, 20, 17, 38, 20, 495, DateTimeKind.Local).AddTicks(3297) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "ModifiedDate", "RecordDate" },
                values: new object[] { new DateTime(2022, 10, 20, 17, 38, 20, 495, DateTimeKind.Local).AddTicks(3301), new DateTime(2022, 10, 20, 17, 38, 20, 495, DateTimeKind.Local).AddTicks(3300) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "ModifiedDate", "RecordDate" },
                values: new object[] { new DateTime(2022, 10, 20, 17, 38, 20, 495, DateTimeKind.Local).AddTicks(3304), new DateTime(2022, 10, 20, 17, 38, 20, 495, DateTimeKind.Local).AddTicks(3303) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5,
                columns: new[] { "ModifiedDate", "RecordDate" },
                values: new object[] { new DateTime(2022, 10, 20, 17, 38, 20, 495, DateTimeKind.Local).AddTicks(3307), new DateTime(2022, 10, 20, 17, 38, 20, 495, DateTimeKind.Local).AddTicks(3306) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6,
                columns: new[] { "ModifiedDate", "RecordDate" },
                values: new object[] { new DateTime(2022, 10, 20, 17, 38, 20, 495, DateTimeKind.Local).AddTicks(3310), new DateTime(2022, 10, 20, 17, 38, 20, 495, DateTimeKind.Local).AddTicks(3309) });
        }
    }
}
