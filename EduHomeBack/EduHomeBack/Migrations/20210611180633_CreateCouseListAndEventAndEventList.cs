using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EduHomeBack.Migrations
{
    public partial class CreateCouseListAndEventAndEventList : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TeacherCourse_Course_CourseId",
                table: "TeacherCourse");

            migrationBuilder.RenameColumn(
                name: "CourseId",
                table: "TeacherCourse",
                newName: "CourseListId");

            migrationBuilder.RenameIndex(
                name: "IX_TeacherCourse_CourseId",
                table: "TeacherCourse",
                newName: "IX_TeacherCourse_CourseListId");

            migrationBuilder.AlterColumn<double>(
                name: "CourseFee",
                table: "Course",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<string>(
                name: "Assesments",
                table: "Course",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "CourseListId",
                table: "Course",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Start",
                table: "Course",
                type: "nvarchar(max)",
                nullable: true);

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

            migrationBuilder.CreateTable(
                name: "EventList",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TimeStart = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: DateTime.UtcNow),
                    TimeEnd = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: DateTime.UtcNow),
                    VenueCity = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventList", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TimeStart = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: DateTime.UtcNow),
                    TimeEnd = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: DateTime.UtcNow),
                    VenuePlace = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VenueCity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EventListId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Events_EventList_EventListId",
                        column: x => x.EventListId,
                        principalTable: "EventList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Course_CourseListId",
                table: "Course",
                column: "CourseListId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Events_EventListId",
                table: "Events",
                column: "EventListId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Course_CourseList_CourseListId",
                table: "Course",
                column: "CourseListId",
                principalTable: "CourseList",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TeacherCourse_CourseList_CourseListId",
                table: "TeacherCourse",
                column: "CourseListId",
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
                name: "FK_TeacherCourse_CourseList_CourseListId",
                table: "TeacherCourse");

            migrationBuilder.DropTable(
                name: "CourseList");

            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "EventList");

            migrationBuilder.DropIndex(
                name: "IX_Course_CourseListId",
                table: "Course");

            migrationBuilder.DropColumn(
                name: "CourseListId",
                table: "Course");

            migrationBuilder.DropColumn(
                name: "Start",
                table: "Course");

            migrationBuilder.RenameColumn(
                name: "CourseListId",
                table: "TeacherCourse",
                newName: "CourseId");

            migrationBuilder.RenameIndex(
                name: "IX_TeacherCourse_CourseListId",
                table: "TeacherCourse",
                newName: "IX_TeacherCourse_CourseId");

            migrationBuilder.AlterColumn<decimal>(
                name: "CourseFee",
                table: "Course",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<int>(
                name: "Assesments",
                table: "Course",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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
