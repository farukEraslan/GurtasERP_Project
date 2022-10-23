using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gurtas.Migrations
{
    public partial class seed_data_suppliers_table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "MeasureTools",
                keyColumn: "ToolId",
                keyValue: 1,
                columns: new[] { "ModifiedDate", "RecordDate" },
                values: new object[] { new DateTime(2022, 10, 22, 20, 38, 38, 805, DateTimeKind.Local).AddTicks(6129), new DateTime(2022, 10, 22, 20, 38, 38, 805, DateTimeKind.Local).AddTicks(6125) });

            migrationBuilder.InsertData(
                table: "Suppliers",
                columns: new[] { "SupplierId", "Address", "CompanyName", "CompanyRating", "ContactName", "Goods", "IsApproved", "ModifiedDate", "Phone", "RecordDate", "TaxOfficeAndNumber", "UserId" },
                values: new object[] { 1, "Karadenizliler mah. Ordulu Cad.", "Gürtaş", 100, "Faruk Eraslan", "Makine İmalatı", true, new DateTime(2022, 10, 22, 20, 38, 38, 806, DateTimeKind.Local).AddTicks(5042), "0262 123 45 67", new DateTime(2022, 10, 22, 20, 38, 38, 806, DateTimeKind.Local).AddTicks(5036), "1234567890", 1 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "ModifiedDate", "RecordDate" },
                values: new object[] { new DateTime(2022, 10, 22, 20, 38, 38, 805, DateTimeKind.Local).AddTicks(1974), new DateTime(2022, 10, 22, 20, 38, 38, 805, DateTimeKind.Local).AddTicks(1964) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "ModifiedDate", "RecordDate" },
                values: new object[] { new DateTime(2022, 10, 22, 20, 38, 38, 805, DateTimeKind.Local).AddTicks(1977), new DateTime(2022, 10, 22, 20, 38, 38, 805, DateTimeKind.Local).AddTicks(1976) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "ModifiedDate", "RecordDate" },
                values: new object[] { new DateTime(2022, 10, 22, 20, 38, 38, 805, DateTimeKind.Local).AddTicks(1979), new DateTime(2022, 10, 22, 20, 38, 38, 805, DateTimeKind.Local).AddTicks(1978) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "ModifiedDate", "RecordDate" },
                values: new object[] { new DateTime(2022, 10, 22, 20, 38, 38, 805, DateTimeKind.Local).AddTicks(1982), new DateTime(2022, 10, 22, 20, 38, 38, 805, DateTimeKind.Local).AddTicks(1980) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5,
                columns: new[] { "ModifiedDate", "RecordDate" },
                values: new object[] { new DateTime(2022, 10, 22, 20, 38, 38, 805, DateTimeKind.Local).AddTicks(1984), new DateTime(2022, 10, 22, 20, 38, 38, 805, DateTimeKind.Local).AddTicks(1983) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6,
                columns: new[] { "ModifiedDate", "RecordDate" },
                values: new object[] { new DateTime(2022, 10, 22, 20, 38, 38, 805, DateTimeKind.Local).AddTicks(1986), new DateTime(2022, 10, 22, 20, 38, 38, 805, DateTimeKind.Local).AddTicks(1985) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "SupplierId",
                keyValue: 1);

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
    }
}
