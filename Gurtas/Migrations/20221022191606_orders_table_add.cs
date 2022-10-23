using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gurtas.Migrations
{
    public partial class orders_table_add : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderNumber = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    BidNumber = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Quantity = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Material = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DeliveryTime = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Discount = table.Column<int>(type: "int", nullable: true),
                    PackagingDetail = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ShippingDetail = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    PaymentMethod = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    PaymentTerm = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RecordDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                    table.ForeignKey(
                        name: "FK_Orders_Users_UserId",
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
                values: new object[] { new DateTime(2022, 10, 22, 22, 16, 6, 78, DateTimeKind.Local).AddTicks(7643), new DateTime(2022, 10, 22, 22, 16, 6, 78, DateTimeKind.Local).AddTicks(7640) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "SupplierId",
                keyValue: 1,
                columns: new[] { "ModifiedDate", "RecordDate" },
                values: new object[] { new DateTime(2022, 10, 22, 22, 16, 6, 79, DateTimeKind.Local).AddTicks(2174), new DateTime(2022, 10, 22, 22, 16, 6, 79, DateTimeKind.Local).AddTicks(2171) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "ModifiedDate", "RecordDate" },
                values: new object[] { new DateTime(2022, 10, 22, 22, 16, 6, 78, DateTimeKind.Local).AddTicks(5250), new DateTime(2022, 10, 22, 22, 16, 6, 78, DateTimeKind.Local).AddTicks(5239) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "ModifiedDate", "RecordDate" },
                values: new object[] { new DateTime(2022, 10, 22, 22, 16, 6, 78, DateTimeKind.Local).AddTicks(5253), new DateTime(2022, 10, 22, 22, 16, 6, 78, DateTimeKind.Local).AddTicks(5252) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "ModifiedDate", "RecordDate" },
                values: new object[] { new DateTime(2022, 10, 22, 22, 16, 6, 78, DateTimeKind.Local).AddTicks(5254), new DateTime(2022, 10, 22, 22, 16, 6, 78, DateTimeKind.Local).AddTicks(5254) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "ModifiedDate", "RecordDate" },
                values: new object[] { new DateTime(2022, 10, 22, 22, 16, 6, 78, DateTimeKind.Local).AddTicks(5256), new DateTime(2022, 10, 22, 22, 16, 6, 78, DateTimeKind.Local).AddTicks(5256) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5,
                columns: new[] { "ModifiedDate", "RecordDate" },
                values: new object[] { new DateTime(2022, 10, 22, 22, 16, 6, 78, DateTimeKind.Local).AddTicks(5258), new DateTime(2022, 10, 22, 22, 16, 6, 78, DateTimeKind.Local).AddTicks(5257) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6,
                columns: new[] { "ModifiedDate", "RecordDate" },
                values: new object[] { new DateTime(2022, 10, 22, 22, 16, 6, 78, DateTimeKind.Local).AddTicks(5259), new DateTime(2022, 10, 22, 22, 16, 6, 78, DateTimeKind.Local).AddTicks(5259) });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orders");

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
    }
}
