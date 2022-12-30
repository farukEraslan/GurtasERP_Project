using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gurtas.Migrations
{
    public partial class customer_and_projects_seedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "Address", "City", "ContactTitle", "Country", "CustomerName", "Email", "ModifiedDate", "Phone", "PostalCode", "RecordDate", "UserId" },
                values: new object[] { 1, "Ostre Kullerod 3 | 3241 Snaderfjord | Norway", "Sandefjord", "Roger Hagen", "Norway", "Amiblu", "roger.hagen@amiblu.com", new DateTime(2022, 11, 10, 16, 14, 56, 378, DateTimeKind.Local).AddTicks(6179), "+47 452 26 710", "3241", new DateTime(2022, 11, 10, 16, 14, 56, 378, DateTimeKind.Local).AddTicks(6170), 1 });

            migrationBuilder.UpdateData(
                table: "MeasureTools",
                keyColumn: "ToolId",
                keyValue: 1,
                columns: new[] { "ModifiedDate", "RecordDate" },
                values: new object[] { new DateTime(2022, 11, 10, 16, 14, 56, 377, DateTimeKind.Local).AddTicks(5349), new DateTime(2022, 11, 10, 16, 14, 56, 377, DateTimeKind.Local).AddTicks(5341) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "SupplierId",
                keyValue: 1,
                columns: new[] { "ModifiedDate", "RecordDate" },
                values: new object[] { new DateTime(2022, 11, 10, 16, 14, 56, 379, DateTimeKind.Local).AddTicks(2714), new DateTime(2022, 11, 10, 16, 14, 56, 379, DateTimeKind.Local).AddTicks(2706) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "ModifiedDate", "RecordDate" },
                values: new object[] { new DateTime(2022, 11, 10, 16, 14, 56, 376, DateTimeKind.Local).AddTicks(7095), new DateTime(2022, 11, 10, 16, 14, 56, 376, DateTimeKind.Local).AddTicks(7072) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "ModifiedDate", "RecordDate" },
                values: new object[] { new DateTime(2022, 11, 10, 16, 14, 56, 376, DateTimeKind.Local).AddTicks(7104), new DateTime(2022, 11, 10, 16, 14, 56, 376, DateTimeKind.Local).AddTicks(7102) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "ModifiedDate", "RecordDate" },
                values: new object[] { new DateTime(2022, 11, 10, 16, 14, 56, 376, DateTimeKind.Local).AddTicks(7111), new DateTime(2022, 11, 10, 16, 14, 56, 376, DateTimeKind.Local).AddTicks(7108) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "ModifiedDate", "RecordDate" },
                values: new object[] { new DateTime(2022, 11, 10, 16, 14, 56, 376, DateTimeKind.Local).AddTicks(7116), new DateTime(2022, 11, 10, 16, 14, 56, 376, DateTimeKind.Local).AddTicks(7114) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5,
                columns: new[] { "ModifiedDate", "RecordDate" },
                values: new object[] { new DateTime(2022, 11, 10, 16, 14, 56, 376, DateTimeKind.Local).AddTicks(7121), new DateTime(2022, 11, 10, 16, 14, 56, 376, DateTimeKind.Local).AddTicks(7119) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6,
                columns: new[] { "ModifiedDate", "RecordDate" },
                values: new object[] { new DateTime(2022, 11, 10, 16, 14, 56, 376, DateTimeKind.Local).AddTicks(7126), new DateTime(2022, 11, 10, 16, 14, 56, 376, DateTimeKind.Local).AddTicks(7125) });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "ProjectId", "CustomerId", "IsFinished", "ModifiedDate", "ProjectName", "ProjectNumber", "RecordDate", "UserId" },
                values: new object[,]
                {
                    { 1, 1, true, new DateTime(2022, 11, 10, 16, 14, 56, 380, DateTimeKind.Local).AddTicks(2283), "545-AR Catalyst System", "PO 77684-1", new DateTime(2022, 11, 10, 16, 14, 56, 380, DateTimeKind.Local).AddTicks(2274), 1 },
                    { 2, 1, true, new DateTime(2022, 11, 10, 16, 14, 56, 380, DateTimeKind.Local).AddTicks(2293), "545-AR Machine Saw Carriage and Feeder", "PO 77704-1", new DateTime(2022, 11, 10, 16, 14, 56, 380, DateTimeKind.Local).AddTicks(2291), 1 },
                    { 3, 1, true, new DateTime(2022, 11, 10, 16, 14, 56, 380, DateTimeKind.Local).AddTicks(2299), "545-AR Chopper 500 - 1500", "PO 77736-1", new DateTime(2022, 11, 10, 16, 14, 56, 380, DateTimeKind.Local).AddTicks(2297), 1 },
                    { 4, 1, true, new DateTime(2022, 11, 10, 16, 14, 56, 380, DateTimeKind.Local).AddTicks(2304), "545-AR Steel Band Tensioner", "PO 77793-1", new DateTime(2022, 11, 10, 16, 14, 56, 380, DateTimeKind.Local).AddTicks(2302), 1 },
                    { 5, 1, true, new DateTime(2022, 11, 10, 16, 14, 56, 380, DateTimeKind.Local).AddTicks(2474), "545-AR Sandbox 100", "PO 77810-1", new DateTime(2022, 11, 10, 16, 14, 56, 380, DateTimeKind.Local).AddTicks(2471), 1 },
                    { 6, 1, true, new DateTime(2022, 11, 10, 16, 14, 56, 380, DateTimeKind.Local).AddTicks(2480), "545-AR Platform Spindle Lifting", "PO 77912-1", new DateTime(2022, 11, 10, 16, 14, 56, 380, DateTimeKind.Local).AddTicks(2478), 1 },
                    { 7, 1, true, new DateTime(2022, 11, 10, 16, 14, 56, 380, DateTimeKind.Local).AddTicks(2485), "545-AR Resin Mix Small Parts", "PO 77923-1", new DateTime(2022, 11, 10, 16, 14, 56, 380, DateTimeKind.Local).AddTicks(2483), 1 },
                    { 8, 1, true, new DateTime(2022, 11, 10, 16, 14, 56, 380, DateTimeKind.Local).AddTicks(2490), "545-AR Netting Tensioner E1 Upgrade", "PO 77924-1", new DateTime(2022, 11, 10, 16, 14, 56, 380, DateTimeKind.Local).AddTicks(2488), 1 },
                    { 9, 1, true, new DateTime(2022, 11, 10, 16, 14, 56, 380, DateTimeKind.Local).AddTicks(2495), "545-AR Gear Drive System", "PO 77938-1", new DateTime(2022, 11, 10, 16, 14, 56, 380, DateTimeKind.Local).AddTicks(2493), 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 1);

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
    }
}
