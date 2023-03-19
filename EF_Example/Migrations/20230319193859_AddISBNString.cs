using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_Example.Migrations
{
    public partial class AddISBNString : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ISBN = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: true),
                    Book_Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Catergory = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "User_Role",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Role_Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User_Role", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserData",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    User_id = table.Column<long>(type: "bigint", nullable: false),
                    Book_Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Amount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserData", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "UserLogin",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    User_name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Password = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    User_Role = table.Column<int>(type: "int", maxLength: 3, nullable: true, defaultValue: 3),
                    Login_date = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLogin", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "User_Role",
                columns: new[] { "Id", "Role_Name" },
                values: new object[,]
                {
                    { 0, "Banned" },
                    { 1, "Admin" },
                    { 2, "Logistic" },
                    { 3, "User" },
                    { 4, "ManageLogistic" },
                    { 5, "Director" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Books_id",
                table: "Books",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_User_Role_Id",
                table: "User_Role",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserData_id",
                table: "UserData",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserLogin_id",
                table: "UserLogin",
                column: "id",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "User_Role");

            migrationBuilder.DropTable(
                name: "UserData");

            migrationBuilder.DropTable(
                name: "UserLogin");
        }
    }
}
