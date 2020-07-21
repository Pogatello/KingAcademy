using Microsoft.EntityFrameworkCore.Migrations;

namespace KingICT.Academy.Repository.Migrations
{
    public partial class Test2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentCourse_Student_StudentId1",
                table: "StudentCourse");

            migrationBuilder.DropIndex(
                name: "IX_StudentCourse_StudentId1",
                table: "StudentCourse");

            migrationBuilder.DropColumn(
                name: "StudentId1",
                table: "StudentCourse");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StudentId1",
                table: "StudentCourse",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_StudentCourse_StudentId1",
                table: "StudentCourse",
                column: "StudentId1");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentCourse_Student_StudentId1",
                table: "StudentCourse",
                column: "StudentId1",
                principalTable: "Student",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
