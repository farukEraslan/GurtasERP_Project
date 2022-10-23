using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gurtas.Migrations
{
    public partial class suppliers_table_update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsApproved",
                table: "Suppliers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "MeasureTools",
                keyColumn: "ToolId",
                keyValue: 1,
                columns: new[] { "ModifiedDate", "RecordDate" },
                values: new object[] { new DateTime(2022, 10, 22, 20, 26, 17, 651, DateTimeKind.Local).AddTicks(5935), new DateTime(2022, 10, 22, 20, 26, 17, 651, DateTimeKind.Local).AddTicks(5926) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "ModifiedDate", "RecordDate" },
                values: new object[] { new DateTime(2022, 10, 22, 20, 26, 17, 651, DateTimeKind.Local).AddTicks(1025), new DateTime(2022, 10, 22, 20, 26, 17, 651, DateTimeKind.Local).AddTicks(1013) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "ModifiedDate", "RecordDate" },
                values: new object[] { new DateTime(2022, 10, 22, 20, 26, 17, 651, DateTimeKind.Local).AddTicks(1027), new DateTime(2022, 10, 22, 20, 26, 17, 651, DateTimeKind.Local).AddTicks(1027) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "ModifiedDate", "RecordDate" },
                values: new object[] { new DateTime(2022, 10, 22, 20, 26, 17, 651, DateTimeKind.Local).AddTicks(1029), new DateTime(2022, 10, 22, 20, 26, 17, 651, DateTimeKind.Local).AddTicks(1029) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "ModifiedDate", "RecordDate" },
                values: new object[] { new DateTime(2022, 10, 22, 20, 26, 17, 651, DateTimeKind.Local).AddTicks(1031), new DateTime(2022, 10, 22, 20, 26, 17, 651, DateTimeKind.Local).AddTicks(1030) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5,
                columns: new[] { "ModifiedDate", "RecordDate" },
                values: new object[] { new DateTime(2022, 10, 22, 20, 26, 17, 651, DateTimeKind.Local).AddTicks(1032), new DateTime(2022, 10, 22, 20, 26, 17, 651, DateTimeKind.Local).AddTicks(1032) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6,
                columns: new[] { "ModifiedDate", "RecordDate" },
                values: new object[] { new DateTime(2022, 10, 22, 20, 26, 17, 651, DateTimeKind.Local).AddTicks(1034), new DateTime(2022, 10, 22, 20, 26, 17, 651, DateTimeKind.Local).AddTicks(1033) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsApproved",
                table: "Suppliers");

            migrationBuilder.UpdateData(
                table: "MeasureTools",
                keyColumn: "ToolId",
                keyValue: 1,
                columns: new[] { "ModifiedDate", "RecordDate" },
                values: new object[] { new DateTime(2022, 10, 22, 20, 22, 21, 340, DateTimeKind.Local).AddTicks(9278), new DateTime(2022, 10, 22, 20, 22, 21, 340, DateTimeKind.Local).AddTicks(9274) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "ModifiedDate", "RecordDate" },
                values: new object[] { new DateTime(2022, 10, 22, 20, 22, 21, 340, DateTimeKind.Local).AddTicks(6312), new DateTime(2022, 10, 22, 20, 22, 21, 340, DateTimeKind.Local).AddTicks(6300) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "ModifiedDate", "RecordDate" },
                values: new object[] { new DateTime(2022, 10, 22, 20, 22, 21, 340, DateTimeKind.Local).AddTicks(6315), new DateTime(2022, 10, 22, 20, 22, 21, 340, DateTimeKind.Local).AddTicks(6314) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "ModifiedDate", "RecordDate" },
                values: new object[] { new DateTime(2022, 10, 22, 20, 22, 21, 340, DateTimeKind.Local).AddTicks(6317), new DateTime(2022, 10, 22, 20, 22, 21, 340, DateTimeKind.Local).AddTicks(6316) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "ModifiedDate", "RecordDate" },
                values: new object[] { new DateTime(2022, 10, 22, 20, 22, 21, 340, DateTimeKind.Local).AddTicks(6318), new DateTime(2022, 10, 22, 20, 22, 21, 340, DateTimeKind.Local).AddTicks(6318) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5,
                columns: new[] { "ModifiedDate", "RecordDate" },
                values: new object[] { new DateTime(2022, 10, 22, 20, 22, 21, 340, DateTimeKind.Local).AddTicks(6320), new DateTime(2022, 10, 22, 20, 22, 21, 340, DateTimeKind.Local).AddTicks(6320) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6,
                columns: new[] { "ModifiedDate", "RecordDate" },
                values: new object[] { new DateTime(2022, 10, 22, 20, 22, 21, 340, DateTimeKind.Local).AddTicks(6322), new DateTime(2022, 10, 22, 20, 22, 21, 340, DateTimeKind.Local).AddTicks(6321) });
        }
    }
}
