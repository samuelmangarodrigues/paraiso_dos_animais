using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ParaisoDosAnimais.Migrations
{
    /// <inheritdoc />
    public partial class AddNewRlsp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductCarts_Carts_CartId1",
                table: "ProductCarts");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductCarts_Products_ProductId1",
                table: "ProductCarts");

            migrationBuilder.DropIndex(
                name: "IX_ProductCarts_CartId1",
                table: "ProductCarts");

            migrationBuilder.DropIndex(
                name: "IX_ProductCarts_ProductId1",
                table: "ProductCarts");

            migrationBuilder.DropColumn(
                name: "CartId1",
                table: "ProductCarts");

            migrationBuilder.DropColumn(
                name: "ProductId1",
                table: "ProductCarts");

            migrationBuilder.AddColumn<Guid>(
                name: "CategoryId",
                table: "Products",
                type: "TEXT",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<Guid>(
                name: "ProductId",
                table: "ProductCarts",
                type: "TEXT",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "CartId",
                table: "ProductCarts",
                type: "TEXT",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ClientId",
                table: "Carts",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TotalValue",
                table: "Carts",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AlterColumn<string>(
                name: "ClientId",
                table: "Addresses",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCarts_CartId",
                table: "ProductCarts",
                column: "CartId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCarts_ProductId",
                table: "ProductCarts",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductCarts_Carts_CartId",
                table: "ProductCarts",
                column: "CartId",
                principalTable: "Carts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductCarts_Products_ProductId",
                table: "ProductCarts",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductCarts_Carts_CartId",
                table: "ProductCarts");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductCarts_Products_ProductId",
                table: "ProductCarts");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Products_CategoryId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_ProductCarts_CartId",
                table: "ProductCarts");

            migrationBuilder.DropIndex(
                name: "IX_ProductCarts_ProductId",
                table: "ProductCarts");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "TotalValue",
                table: "Carts");

            migrationBuilder.AlterColumn<string>(
                name: "ProductId",
                table: "ProductCarts",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "CartId",
                table: "ProductCarts",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "TEXT");

            migrationBuilder.AddColumn<Guid>(
                name: "CartId1",
                table: "ProductCarts",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ProductId1",
                table: "ProductCarts",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ClientId",
                table: "Carts",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "ClientId",
                table: "Addresses",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCarts_CartId1",
                table: "ProductCarts",
                column: "CartId1");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCarts_ProductId1",
                table: "ProductCarts",
                column: "ProductId1");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductCarts_Carts_CartId1",
                table: "ProductCarts",
                column: "CartId1",
                principalTable: "Carts",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductCarts_Products_ProductId1",
                table: "ProductCarts",
                column: "ProductId1",
                principalTable: "Products",
                principalColumn: "Id");
        }
    }
}
