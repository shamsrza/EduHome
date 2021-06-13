using Microsoft.EntityFrameworkCore.Migrations;

namespace EduHomeBack.Migrations
{
    public partial class CreateCategoryTableAndAddingIsDeletedIntoCourseAndEventTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "EventList",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "EventList",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "CourseList",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "CourseList",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "BlogList",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EventList_CategoryId",
                table: "EventList",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseList_CategoryId",
                table: "CourseList",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_BlogList_CategoryId",
                table: "BlogList",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_BlogList_Categories_CategoryId",
                table: "BlogList",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseList_Categories_CategoryId",
                table: "CourseList",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EventList_Categories_CategoryId",
                table: "EventList",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BlogList_Categories_CategoryId",
                table: "BlogList");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseList_Categories_CategoryId",
                table: "CourseList");

            migrationBuilder.DropForeignKey(
                name: "FK_EventList_Categories_CategoryId",
                table: "EventList");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_EventList_CategoryId",
                table: "EventList");

            migrationBuilder.DropIndex(
                name: "IX_CourseList_CategoryId",
                table: "CourseList");

            migrationBuilder.DropIndex(
                name: "IX_BlogList_CategoryId",
                table: "BlogList");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "EventList");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "EventList");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "CourseList");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "CourseList");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "BlogList");
        }
    }
}
