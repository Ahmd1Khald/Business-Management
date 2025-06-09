using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Stationery_Store.Migrations
{
    /// <inheritdoc />
    public partial class EditeOrderItemsDeleteBehavior : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_Items_Products_ProductId",
                table: "Order_Items");

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "Order_Items",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddColumn<string>(
                name: "ProductName",
                table: "Order_Items",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Items_Products_ProductId",
                table: "Order_Items",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "ID",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_Items_Products_ProductId",
                table: "Order_Items");

            migrationBuilder.DropColumn(
                name: "ProductName",
                table: "Order_Items");

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "Order_Items",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Items_Products_ProductId",
                table: "Order_Items",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
