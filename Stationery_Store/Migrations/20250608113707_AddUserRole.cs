using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Stationery_Store.Migrations
{
    /// <inheritdoc />
    public partial class AddUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserRole",
                table: "Users",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "NationalID", "Password", "Phone", "UserName", "UserRole" },
                values: new object[,]
                {
                    { 1, "12345678912345", "123456", "01061748098", "Ahmed", 0 },
                    { 2, "12345678912345", "123456", "01061748098", "Khaled", 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "UserRole",
                table: "Users");
        }
    }
}
