using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RaellShoes.Migrations
{
    public partial class Adm : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CarrinhoId",
                table: "Produto",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CarrinhoId",
                table: "Cartao",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Cupom",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    DataCadastro = table.Column<DateTime>(nullable: false),
                    Codigo = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cupom", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Carrinho",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ValorFrete = table.Column<double>(nullable: false),
                    ValorTotal = table.Column<double>(nullable: false),
                    ClienteId = table.Column<int>(nullable: false),
                    EnderecoEntregaId = table.Column<int>(nullable: false),
                    CupomId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carrinho", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Carrinho_Cliente_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Cliente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Carrinho_Cupom_CupomId",
                        column: x => x.CupomId,
                        principalTable: "Cupom",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Carrinho_Endereco_EnderecoEntregaId",
                        column: x => x.EnderecoEntregaId,
                        principalTable: "Endereco",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Produto_CarrinhoId",
                table: "Produto",
                column: "CarrinhoId");

            migrationBuilder.CreateIndex(
                name: "IX_Cartao_CarrinhoId",
                table: "Cartao",
                column: "CarrinhoId");

            migrationBuilder.CreateIndex(
                name: "IX_Carrinho_ClienteId",
                table: "Carrinho",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Carrinho_CupomId",
                table: "Carrinho",
                column: "CupomId");

            migrationBuilder.CreateIndex(
                name: "IX_Carrinho_EnderecoEntregaId",
                table: "Carrinho",
                column: "EnderecoEntregaId");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cartao_Carrinho_CarrinhoId",
                table: "Cartao");

            migrationBuilder.DropForeignKey(
                name: "FK_Produto_Carrinho_CarrinhoId",
                table: "Produto");

            migrationBuilder.DropTable(
                name: "Carrinho");

            migrationBuilder.DropTable(
                name: "Cupom");

            migrationBuilder.DropIndex(
                name: "IX_Produto_CarrinhoId",
                table: "Produto");

            migrationBuilder.DropIndex(
                name: "IX_Cartao_CarrinhoId",
                table: "Cartao");

            migrationBuilder.DropColumn(
                name: "CarrinhoId",
                table: "Produto");

            migrationBuilder.DropColumn(
                name: "CarrinhoId",
                table: "Cartao");
        }
    }
}
