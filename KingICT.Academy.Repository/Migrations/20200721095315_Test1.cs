using Microsoft.EntityFrameworkCore.Migrations;

namespace KingICT.Academy.Repository.Migrations
{
    public partial class Test1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentCourse_Course_CourseId1",
                table: "StudentCourse");

            migrationBuilder.DropIndex(
                name: "IX_StudentCourse_CourseId1",
                table: "StudentCourse");

            migrationBuilder.DropColumn(
                name: "CourseId1",
                table: "StudentCourse");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CourseId1",
                table: "StudentCourse",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_StudentCourse_CourseId1",
                table: "StudentCourse",
                column: "CourseId1");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentCourse_Course_CourseId1",
                table: "StudentCourse",
                column: "CourseId1",
                principalTable: "Course",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
