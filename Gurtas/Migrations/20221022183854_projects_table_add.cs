using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gurtas.Migrations
{
    public partial class projects_table_add : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    ProjectId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectNumber = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    ProjectName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    RecordDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.ProjectId);
                    table.ForeignKey(
                        name: "FK_Projects_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Projects_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Projects_CustomerId",
                table: "Projects",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_UserId",
                table: "Projects",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.UpdateData(
                table: "MeasureTools",
                keyColumn: "ToolId",
                keyValue: 1,
                columns: new[] { "ModifiedDate", "RecordDate" },
                values: new object[] { new DateTime(2022, 10, 22, 20, 38, 38, 805, DateTimeKind.Local).AddTicks(6129), new DateTime(2022, 10, 22, 20, 38, 38, 805, DateTimeKind.Local).AddTicks(6125) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "SupplierId",
                keyValue: 1,
                columns: new[] { "ModifiedDate", "RecordDate" },
                values: new object[] { new DateTime(2022, 10, 22, 20, 38, 38, 806, DateTimeKind.Local).AddTicks(5042), new DateTime(2022, 10, 22, 20, 38, 38, 806, DateTimeKind.Local).AddTicks(5036) });

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
    }
}
