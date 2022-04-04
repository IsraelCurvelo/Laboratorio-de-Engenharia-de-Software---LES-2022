using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RaellShoes.Migrations
{
    public partial class Coorecao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cartao_Carrinho_CarrinhoId",
                table: "Cartao");

            migrationBuilder.DropForeignKey(
                name: "FK_Produto_Carrinho_CarrinhoId",
                table: "Produto");

            migrationBuilder.DropIndex(
                name: "IX_Cartao_CarrinhoId",
                table: "Cartao");

            migrationBuilder.DropColumn(
                name: "CarrinhoId",
                table: "Cartao");

            migrationBuilder.RenameColumn(
                name: "CarrinhoId",
                table: "Produto",
                newName: "PedidoId");

            migrationBuilder.RenameIndex(
                name: "IX_Produto_CarrinhoId",
                table: "Produto",
                newName: "IX_Produto_PedidoId");

            migrationBuilder.CreateTable(
                name: "Pedido",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NumeroPedido = table.Column<string>(nullable: false),
                    ValorTotal = table.Column<double>(nullable: false),
                    DataCompra = table.Column<DateTime>(nullable: false),
                    EnderecoEntrega = table.Column<string>(nullable: false),
                    FormaPagamento = table.Column<int>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    ClienteId = table.Column<int>(nullable: false),
                    CupomId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pedido", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pedido_Cliente_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Cliente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pedido_Cupom_CupomId",
                        column: x => x.CupomId,
                        principalTable: "Cupom",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pedido_ClienteId",
                table: "Pedido",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Pedido_CupomId",
                table: "Pedido",
                column: "CupomId");

            migrationBuilder.AddForeignKey(
                name: "FK_Produto_Pedido_PedidoId",
                table: "Produto",
                column: "PedidoId",
                principalTable: "Pedido",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produto_Pedido_PedidoId",
                table: "Produto");

            migrationBuilder.DropTable(
                name: "Pedido");

            migrationBuilder.RenameColumn(
                name: "PedidoId",
                table: "Produto",
                newName: "CarrinhoId");

            migrationBuilder.RenameIndex(
                name: "IX_Produto_PedidoId",
                table: "Produto",
                newName: "IX_Produto_CarrinhoId");

            migrationBuilder.AddColumn<int>(
                name: "CarrinhoId",
                table: "Cartao",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cartao_CarrinhoId",
                table: "Cartao",
                column: "CarrinhoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cartao_Carrinho_CarrinhoId",
                table: "Cartao",
                column: "CarrinhoId",
                principalTable: "Carrinho",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Produto_Carrinho_CarrinhoId",
                table: "Produto",
                column: "CarrinhoId",
                principalTable: "Carrinho",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
