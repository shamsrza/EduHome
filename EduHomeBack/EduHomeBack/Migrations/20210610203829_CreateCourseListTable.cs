using Microsoft.EntityFrameworkCore.Migrations;

namespace EduHomeBack.Migrations
{
    public partial class CreateCourseListTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TeacherCourse_Course_CourseId",
                table: "TeacherCourse");

            migrationBuilder.AlterColumn<double>(
                name: "CourseFee",
                table: "Course",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AddColumn<int>(
                name: "CourseListId",
                table: "Course",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "CourseList",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseList", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Course_CourseListId",
                table: "Course",
                column: "CourseListId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Course_CourseList_CourseListId",
                table: "Course",
                column: "CourseListId",
                principalTable: "CourseList",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TeacherCourse_CourseList_CourseId",
                table: "TeacherCourse",
                column: "CourseId",
                principalTable: "CourseList",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Course_CourseList_CourseListId",
                table: "Course");

            migrationBuilder.DropForeignKey(
                name: "FK_TeacherCourse_CourseList_CourseId",
                table: "TeacherCourse");

            migrationBuilder.DropTable(
                name: "CourseList");

            migrationBuilder.DropIndex(
                name: "IX_Course_CourseListId",
                table: "Course");

            migrationBuilder.DropColumn(
                name: "CourseListId",
                table: "Course");

            migrationBuilder.AlterColumn<decimal>(
                name: "CourseFee",
                table: "Course",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AddForeignKey(
                name: "FK_TeacherCourse_Course_CourseId",
                table: "TeacherCourse",
                column: "CourseId",
                principalTable: "Course",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
