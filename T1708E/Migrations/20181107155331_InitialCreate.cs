using Microsoft.EntityFrameworkCore.Migrations;

namespace T1708E.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Mark_Subject_SubjectId1",
                table: "Mark");

            migrationBuilder.DropIndex(
                name: "IX_Mark_SubjectId1",
                table: "Mark");

            migrationBuilder.DropColumn(
                name: "SubjectId1",
                table: "Mark");

            migrationBuilder.RenameColumn(
                name: "Value",
                table: "Mark",
                newName: "SubjectMark");

            migrationBuilder.RenameColumn(
                name: "SubjectId",
                table: "Mark",
                newName: "SubjectName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SubjectName",
                table: "Mark",
                newName: "SubjectId");

            migrationBuilder.RenameColumn(
                name: "SubjectMark",
                table: "Mark",
                newName: "Value");

            migrationBuilder.AddColumn<int>(
                name: "SubjectId1",
                table: "Mark",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Mark_SubjectId1",
                table: "Mark",
                column: "SubjectId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Mark_Subject_SubjectId1",
                table: "Mark",
                column: "SubjectId1",
                principalTable: "Subject",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
