using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gurtas.Migrations
{
    public partial class new_projects_table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsFinished",
                table: "Projects",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "MeasureTools",
                keyColumn: "ToolId",
                keyValue: 1,
                columns: new[] { "ModifiedDate", "RecordDate" },
                values: new object[] { new DateTime(2022, 10, 22, 21, 47, 51, 89, DateTimeKind.Local).AddTicks(6432), new DateTime(2022, 10, 22, 21, 47, 51, 89, DateTimeKind.Local).AddTicks(6429) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "SupplierId",
                keyValue: 1,
                columns: new[] { "ModifiedDate", "RecordDate" },
                values: new object[] { new DateTime(2022, 10, 22, 21, 47, 51, 90, DateTimeKind.Local).AddTicks(3767), new DateTime(2022, 10, 22, 21, 47, 51, 90, DateTimeKind.Local).AddTicks(3761) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "ModifiedDate", "RecordDate" },
                values: new object[] { new DateTime(2022, 10, 22, 21, 47, 51, 89, DateTimeKind.Local).AddTicks(4036), new DateTime(2022, 10, 22, 21, 47, 51, 89, DateTimeKind.Local).AddTicks(4026) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "ModifiedDate", "RecordDate" },
                values: new object[] { new DateTime(2022, 10, 22, 21, 47, 51, 89, DateTimeKind.Local).AddTicks(4038), new DateTime(2022, 10, 22, 21, 47, 51, 89, DateTimeKind.Local).AddTicks(4038) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "ModifiedDate", "RecordDate" },
                values: new object[] { new DateTime(2022, 10, 22, 21, 47, 51, 89, DateTimeKind.Local).AddTicks(4040), new DateTime(2022, 10, 22, 21, 47, 51, 89, DateTimeKind.Local).AddTicks(4039) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "ModifiedDate", "RecordDate" },
                values: new object[] { new DateTime(2022, 10, 22, 21, 47, 51, 89, DateTimeKind.Local).AddTicks(4041), new DateTime(2022, 10, 22, 21, 47, 51, 89, DateTimeKind.Local).AddTicks(4041) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5,
                columns: new[] { "ModifiedDate", "RecordDate" },
                values: new object[] { new DateTime(2022, 10, 22, 21, 47, 51, 89, DateTimeKind.Local).AddTicks(4043), new DateTime(2022, 10, 22, 21, 47, 51, 89, DateTimeKind.Local).AddTicks(4042) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6,
                columns: new[] { "ModifiedDate", "RecordDate" },
                values: new object[] { new DateTime(2022, 10, 22, 21, 47, 51, 89, DateTimeKind.Local).AddTicks(4044), new DateTime(2022, 10, 22, 21, 47, 51, 89, DateTimeKind.Local).AddTicks(4044) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsFinished",
                table: "Projects");

            migrationBuilder.UpdateData(
                table: "MeasureTools",
                keyColumn: "ToolId",
                keyValue: 1,
                columns: new[] { "ModifiedDate", "RecordDate" },
                values: new object[] { new DateTime(2022, 10, 22, 21, 38, 53, 507, DateTimeKind.Local).AddTicks(1717), new DateTime(2022, 10, 22, 21, 38, 53, 507, DateTimeKind.Local).AddTicks(1715) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "SupplierId",
                keyValue: 1,
                columns: new[] { "ModifiedDate", "RecordDate" },
                values: new object[] { new DateTime(2022, 10, 22, 21, 38, 53, 507, DateTimeKind.Local).AddTicks(6368), new DateTime(2022, 10, 22, 21, 38, 53, 507, DateTimeKind.Local).AddTicks(6365) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "ModifiedDate", "RecordDate" },
                values: new object[] { new DateTime(2022, 10, 22, 21, 38, 53, 506, DateTimeKind.Local).AddTicks(9267), new DateTime(2022, 10, 22, 21, 38, 53, 506, DateTimeKind.Local).AddTicks(9258) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "ModifiedDate", "RecordDate" },
                values: new object[] { new DateTime(2022, 10, 22, 21, 38, 53, 506, DateTimeKind.Local).AddTicks(9269), new DateTime(2022, 10, 22, 21, 38, 53, 506, DateTimeKind.Local).AddTicks(9269) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "ModifiedDate", "RecordDate" },
                values: new object[] { new DateTime(2022, 10, 22, 21, 38, 53, 506, DateTimeKind.Local).AddTicks(9271), new DateTime(2022, 10, 22, 21, 38, 53, 506, DateTimeKind.Local).AddTicks(9271) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "ModifiedDate", "RecordDate" },
                values: new object[] { new DateTime(2022, 10, 22, 21, 38, 53, 506, DateTimeKind.Local).AddTicks(9273), new DateTime(2022, 10, 22, 21, 38, 53, 506, DateTimeKind.Local).AddTicks(9272) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5,
                columns: new[] { "ModifiedDate", "RecordDate" },
                values: new object[] { new DateTime(2022, 10, 22, 21, 38, 53, 506, DateTimeKind.Local).AddTicks(9274), new DateTime(2022, 10, 22, 21, 38, 53, 506, DateTimeKind.Local).AddTicks(9274) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6,
                columns: new[] { "ModifiedDate", "RecordDate" },
                values: new object[] { new DateTime(2022, 10, 22, 21, 38, 53, 506, DateTimeKind.Local).AddTicks(9276), new DateTime(2022, 10, 22, 21, 38, 53, 506, DateTimeKind.Local).AddTicks(9275) });
        }
    }
}
