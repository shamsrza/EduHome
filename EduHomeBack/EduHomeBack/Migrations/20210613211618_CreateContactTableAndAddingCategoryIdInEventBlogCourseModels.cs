using Microsoft.EntityFrameworkCore.Migrations;

namespace EduHomeBack.Migrations
{
    public partial class CreateContactTableAndAddingCategoryIdInEventBlogCourseModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstIcon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecondIcon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecondAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThirdIcon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThirdAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contacts");
        }
    }
}
