using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ParaisoDosAnimais.Migrations
{
    /// <inheritdoc />
    public partial class AdjustRelationships : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CartProduct");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CartProduct",
                columns: table => new
                {
                    CartsId = table.Column<Guid>(type: "TEXT", nullable: false),
                    ProductsId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartProduct", x => new { x.CartsId, x.ProductsId });
                    table.ForeignKey(
                        name: "FK_CartProduct_Carts_CartsId",
                        column: x => x.CartsId,
                        principalTable: "Carts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CartProduct_Products_ProductsId",
                        column: x => x.ProductsId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CartProduct_ProductsId",
                table: "CartProduct",
                column: "ProductsId");
        }
    }
}
