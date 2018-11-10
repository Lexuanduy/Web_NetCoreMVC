using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace T1708E.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "RollNumber", "CreatedAt", "Email", "FirstName", "LastName", "Status", "UpdatedAt" },
                values: new object[] { "D00469", new DateTime(2018, 11, 8, 19, 0, 11, 120, DateTimeKind.Local), "admin@gmail.com", "Duy", "Le", 1, new DateTime(2018, 11, 8, 19, 0, 11, 122, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "RollNumber", "CreatedAt", "Email", "FirstName", "LastName", "Status", "UpdatedAt" },
                values: new object[] { "D00529", new DateTime(2018, 11, 8, 19, 0, 11, 123, DateTimeKind.Local), "phuocding@gmail.com", "Phuoc", "Nguyen", 1, new DateTime(2018, 11, 8, 19, 0, 11, 123, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "RollNumber", "CreatedAt", "Email", "FirstName", "LastName", "Status", "UpdatedAt" },
                values: new object[] { "D00553", new DateTime(2018, 11, 8, 19, 0, 11, 123, DateTimeKind.Local), "Vannhat@gmail.com", "Nhat", "Nguyen", 1, new DateTime(2018, 11, 8, 19, 0, 11, 123, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Mark",
                columns: new[] { "Id", "StudentRollNumber", "SubjectMark", "SubjectName" },
                values: new object[] { 1, "D00469", 10, "Java Core" });

            migrationBuilder.InsertData(
                table: "Mark",
                columns: new[] { "Id", "StudentRollNumber", "SubjectMark", "SubjectName" },
                values: new object[] { 2, "D00529", 7, "C#" });

            migrationBuilder.InsertData(
                table: "Mark",
                columns: new[] { "Id", "StudentRollNumber", "SubjectMark", "SubjectName" },
                values: new object[] { 3, "D00553", 8, "PHP" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "RollNumber",
                keyValue: "D00469");

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "RollNumber",
                keyValue: "D00529");

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "RollNumber",
                keyValue: "D00553");
        }
    }
}
