using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gurtas.Migrations
{
    public partial class add_customers_table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    ContactTitle = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Address = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    City = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Country = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    PostalCode = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RecordDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerId);
                    table.ForeignKey(
                        name: "FK_Customers_Users_UserId",
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

            migrationBuilder.CreateIndex(
                name: "IX_Customers_UserId",
                table: "Customers",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");

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
                columns: new[] { "ModifiedDate", "RecordDate" },
                values: new object[] { new DateTime(2022, 10, 21, 23, 37, 49, 98, DateTimeKind.Local).AddTicks(9188), new DateTime(2022, 10, 21, 23, 37, 49, 98, DateTimeKind.Local).AddTicks(9179) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "ModifiedDate", "RecordDate" },
                values: new object[] { new DateTime(2022, 10, 21, 23, 37, 49, 98, DateTimeKind.Local).AddTicks(9190), new DateTime(2022, 10, 21, 23, 37, 49, 98, DateTimeKind.Local).AddTicks(9190) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "ModifiedDate", "RecordDate" },
                values: new object[] { new DateTime(2022, 10, 21, 23, 37, 49, 98, DateTimeKind.Local).AddTicks(9193), new DateTime(2022, 10, 21, 23, 37, 49, 98, DateTimeKind.Local).AddTicks(9192) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "ModifiedDate", "RecordDate" },
                values: new object[] { new DateTime(2022, 10, 21, 23, 37, 49, 98, DateTimeKind.Local).AddTicks(9194), new DateTime(2022, 10, 21, 23, 37, 49, 98, DateTimeKind.Local).AddTicks(9194) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5,
                columns: new[] { "ModifiedDate", "RecordDate" },
                values: new object[] { new DateTime(2022, 10, 21, 23, 37, 49, 98, DateTimeKind.Local).AddTicks(9196), new DateTime(2022, 10, 21, 23, 37, 49, 98, DateTimeKind.Local).AddTicks(9195) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6,
                columns: new[] { "ModifiedDate", "RecordDate" },
                values: new object[] { new DateTime(2022, 10, 21, 23, 37, 49, 98, DateTimeKind.Local).AddTicks(9197), new DateTime(2022, 10, 21, 23, 37, 49, 98, DateTimeKind.Local).AddTicks(9197) });
        }
    }
}
