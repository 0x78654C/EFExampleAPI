using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_Example.Migrations
{
    public partial class RemoveForeignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserLogin_User_Role_UserRole",
                table: "UserLogin");

            migrationBuilder.DropIndex(
                name: "IX_UserLogin_UserRole",
                table: "UserLogin");

            migrationBuilder.DropColumn(
                name: "UserRole",
                table: "UserLogin");

            migrationBuilder.AddColumn<int>(
                name: "User_Role",
                table: "UserLogin",
                type: "int",
                maxLength: 3,
                nullable: true,
                defaultValue: 3);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "User_Role",
                table: "UserLogin");

            migrationBuilder.AddColumn<int>(
                name: "UserRole",
                table: "UserLogin",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_UserLogin_UserRole",
                table: "UserLogin",
                column: "UserRole");

            migrationBuilder.AddForeignKey(
                name: "FK_UserLogin_User_Role_UserRole",
                table: "UserLogin",
                column: "UserRole",
                principalTable: "User_Role",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
