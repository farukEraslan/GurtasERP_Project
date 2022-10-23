using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gurtas.Migrations
{
    public partial class new_column_users : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Users",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Users",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Surname",
                table: "Users",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "MeasureTools",
                keyColumn: "ToolId",
                keyValue: 1,
                columns: new[] { "ModifiedDate", "RecordDate" },
                values: new object[] { new DateTime(2022, 10, 21, 23, 37, 49, 99, DateTimeKind.Local).AddTicks(1329), new DateTime(2022, 10, 21, 23, 37, 49, 99, DateTimeKind.Local).AddTicks(1327) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "Gender", "ModifiedDate", "Name", "RecordDate", "Surname" },
                values: new object[] { "Erkek", new DateTime(2022, 10, 21, 23, 37, 49, 98, DateTimeKind.Local).AddTicks(9188), "Faruk", new DateTime(2022, 10, 21, 23, 37, 49, 98, DateTimeKind.Local).AddTicks(9179), "Eraslan" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "Gender", "ModifiedDate", "Name", "RecordDate", "Surname" },
                values: new object[] { "Erkek", new DateTime(2022, 10, 21, 23, 37, 49, 98, DateTimeKind.Local).AddTicks(9190), "Aykut", new DateTime(2022, 10, 21, 23, 37, 49, 98, DateTimeKind.Local).AddTicks(9190), "Özgür" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "Gender", "ModifiedDate", "Name", "RecordDate", "Surname" },
                values: new object[] { "Erkek", new DateTime(2022, 10, 21, 23, 37, 49, 98, DateTimeKind.Local).AddTicks(9193), "Ali", new DateTime(2022, 10, 21, 23, 37, 49, 98, DateTimeKind.Local).AddTicks(9192), "Yılmaz" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "Gender", "ModifiedDate", "Name", "RecordDate", "Surname" },
                values: new object[] { "Erkek", new DateTime(2022, 10, 21, 23, 37, 49, 98, DateTimeKind.Local).AddTicks(9194), "Cem", new DateTime(2022, 10, 21, 23, 37, 49, 98, DateTimeKind.Local).AddTicks(9194), "Gülpınar" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5,
                columns: new[] { "Gender", "ModifiedDate", "Name", "RecordDate", "Surname" },
                values: new object[] { "Erkek", new DateTime(2022, 10, 21, 23, 37, 49, 98, DateTimeKind.Local).AddTicks(9196), "Orhan", new DateTime(2022, 10, 21, 23, 37, 49, 98, DateTimeKind.Local).AddTicks(9195), "Özgür" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6,
                columns: new[] { "Gender", "ModifiedDate", "Name", "RecordDate", "Surname" },
                values: new object[] { "Erkek", new DateTime(2022, 10, 21, 23, 37, 49, 98, DateTimeKind.Local).AddTicks(9197), "Faruk", new DateTime(2022, 10, 21, 23, 37, 49, 98, DateTimeKind.Local).AddTicks(9197), "Kurtoğlu" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Surname",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "MeasureTools",
                keyColumn: "ToolId",
                keyValue: 1,
                columns: new[] { "ModifiedDate", "RecordDate" },
                values: new object[] { new DateTime(2022, 10, 21, 13, 48, 46, 976, DateTimeKind.Local).AddTicks(7), new DateTime(2022, 10, 21, 13, 48, 46, 975, DateTimeKind.Local).AddTicks(9998) });

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
    }
}
