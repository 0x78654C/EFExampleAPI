using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_Example.Migrations
{
    public partial class FixCategoryTypo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Catergory",
                table: "Books",
                newName: "Category");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Category",
                table: "Books",
                newName: "Catergory");
        }
    }
}
