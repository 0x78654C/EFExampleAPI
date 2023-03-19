using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_Example.Migrations
{
    public partial class UpdateRoles2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "User_Role",
                keyColumn: "Id",
                keyValue: 4,
                column: "Role_Name",
                value: "ManageLogistic");

            migrationBuilder.InsertData(
                table: "User_Role",
                columns: new[] { "Id", "Role_Name" },
                values: new object[] { 5, "Director" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "User_Role",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "User_Role",
                keyColumn: "Id",
                keyValue: 4,
                column: "Role_Name",
                value: "Manager");
        }
    }
}
