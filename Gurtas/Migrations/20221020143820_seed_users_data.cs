using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gurtas.Migrations
{
    public partial class seed_users_data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "ModifiedDate", "Password", "RecordDate", "Username" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 10, 20, 17, 38, 20, 495, DateTimeKind.Local).AddTicks(3294), "qu4lity", new DateTime(2022, 10, 20, 17, 38, 20, 495, DateTimeKind.Local).AddTicks(3281), "farukeraslan" },
                    { 2, new DateTime(2022, 10, 20, 17, 38, 20, 495, DateTimeKind.Local).AddTicks(3298), "own3r", new DateTime(2022, 10, 20, 17, 38, 20, 495, DateTimeKind.Local).AddTicks(3297), "aykutozgur" },
                    { 3, new DateTime(2022, 10, 20, 17, 38, 20, 495, DateTimeKind.Local).AddTicks(3301), "pr0duction", new DateTime(2022, 10, 20, 17, 38, 20, 495, DateTimeKind.Local).AddTicks(3300), "aliyilmaz" },
                    { 4, new DateTime(2022, 10, 20, 17, 38, 20, 495, DateTimeKind.Local).AddTicks(3304), "acc0ntting", new DateTime(2022, 10, 20, 17, 38, 20, 495, DateTimeKind.Local).AddTicks(3303), "cemgulpinar" },
                    { 5, new DateTime(2022, 10, 20, 17, 38, 20, 495, DateTimeKind.Local).AddTicks(3307), "purch4sing", new DateTime(2022, 10, 20, 17, 38, 20, 495, DateTimeKind.Local).AddTicks(3306), "orhanozgur" },
                    { 6, new DateTime(2022, 10, 20, 17, 38, 20, 495, DateTimeKind.Local).AddTicks(3310), "log1stic", new DateTime(2022, 10, 20, 17, 38, 20, 495, DateTimeKind.Local).AddTicks(3309), "farukkurtoglu" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6);
        }
    }
}
