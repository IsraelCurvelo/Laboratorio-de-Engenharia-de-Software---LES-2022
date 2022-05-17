using Microsoft.EntityFrameworkCore.Migrations;

namespace RaellShoes.Migrations
{
    public partial class Categoria : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categoria_Produto_ProdutoId",
                table: "Categoria");

            migrationBuilder.DropIndex(
                name: "IX_Categoria_ProdutoId",
                table: "Categoria");

            migrationBuilder.DropColumn(
                name: "ProdutoId",
                table: "Categoria");

            migrationBuilder.AddColumn<int>(
                name: "CategoriaId",
                table: "ProdutoPedido",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CategoriaId",
                table: "Produto",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ProdutoPedido_CategoriaId",
                table: "ProdutoPedido",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Produto_CategoriaId",
                table: "Produto",
                column: "CategoriaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Produto_Categoria_CategoriaId",
                table: "Produto",
                column: "CategoriaId",
                principalTable: "Categoria",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProdutoPedido_Categoria_CategoriaId",
                table: "ProdutoPedido",
                column: "CategoriaId",
                principalTable: "Categoria",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produto_Categoria_CategoriaId",
                table: "Produto");

            migrationBuilder.DropForeignKey(
                name: "FK_ProdutoPedido_Categoria_CategoriaId",
                table: "ProdutoPedido");

            migrationBuilder.DropIndex(
                name: "IX_ProdutoPedido_CategoriaId",
                table: "ProdutoPedido");

            migrationBuilder.DropIndex(
                name: "IX_Produto_CategoriaId",
                table: "Produto");

            migrationBuilder.DropColumn(
                name: "CategoriaId",
                table: "ProdutoPedido");

            migrationBuilder.DropColumn(
                name: "CategoriaId",
                table: "Produto");

            migrationBuilder.AddColumn<int>(
                name: "ProdutoId",
                table: "Categoria",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Categoria_ProdutoId",
                table: "Categoria",
                column: "ProdutoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Categoria_Produto_ProdutoId",
                table: "Categoria",
                column: "ProdutoId",
                principalTable: "Produto",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
