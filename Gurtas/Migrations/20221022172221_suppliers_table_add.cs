using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gurtas.Migrations
{
    public partial class suppliers_table_add : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    SupplierId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    ContactName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    TaxOfficeAndNumber = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CompanyRating = table.Column<int>(type: "int", nullable: false),
                    Goods = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RecordDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.SupplierId);
                    table.ForeignKey(
                        name: "FK_Suppliers_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Suppliers_UserId",
                table: "Suppliers",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Suppliers");

            migrationBuilder.UpdateData(
                table: "MeasureTools",
                keyColumn: "ToolId",
                keyValue: 1,
                columns: new[] { "ModifiedDate", "RecordDate" },
                values: new object[] { new DateTime(2022, 10, 22, 0, 16, 51, 119, DateTimeKind.Local).AddTicks(6446), new DateTime(2022, 10, 22, 0, 16, 51, 119, DateTimeKind.Local).AddTicks(6443) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "ModifiedDate", "RecordDate" },
                values: new object[] { new DateTime(2022, 10, 22, 0, 16, 51, 119, DateTimeKind.Local).AddTicks(4008), new DateTime(2022, 10, 22, 0, 16, 51, 119, DateTimeKind.Local).AddTicks(4000) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "ModifiedDate", "RecordDate" },
                values: new object[] { new DateTime(2022, 10, 22, 0, 16, 51, 119, DateTimeKind.Local).AddTicks(4012), new DateTime(2022, 10, 22, 0, 16, 51, 119, DateTimeKind.Local).AddTicks(4011) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "ModifiedDate", "RecordDate" },
                values: new object[] { new DateTime(2022, 10, 22, 0, 16, 51, 119, DateTimeKind.Local).AddTicks(4014), new DateTime(2022, 10, 22, 0, 16, 51, 119, DateTimeKind.Local).AddTicks(4013) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "ModifiedDate", "RecordDate" },
                values: new object[] { new DateTime(2022, 10, 22, 0, 16, 51, 119, DateTimeKind.Local).AddTicks(4015), new DateTime(2022, 10, 22, 0, 16, 51, 119, DateTimeKind.Local).AddTicks(4015) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5,
                columns: new[] { "ModifiedDate", "RecordDate" },
                values: new object[] { new DateTime(2022, 10, 22, 0, 16, 51, 119, DateTimeKind.Local).AddTicks(4017), new DateTime(2022, 10, 22, 0, 16, 51, 119, DateTimeKind.Local).AddTicks(4017) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6,
                columns: new[] { "ModifiedDate", "RecordDate" },
                values: new object[] { new DateTime(2022, 10, 22, 0, 16, 51, 119, DateTimeKind.Local).AddTicks(4019), new DateTime(2022, 10, 22, 0, 16, 51, 119, DateTimeKind.Local).AddTicks(4019) });
        }
    }
}
