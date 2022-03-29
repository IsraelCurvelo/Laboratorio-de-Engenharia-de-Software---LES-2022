using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RaellShoes.Migrations
{
    public partial class Admin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FichaTecnica",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Material = table.Column<string>(nullable: false),
                    Palmilha = table.Column<string>(nullable: false),
                    Solado = table.Column<string>(nullable: false),
                    GarantiaMeses = table.Column<int>(nullable: false),
                    Altura = table.Column<int>(nullable: false),
                    Limpeza = table.Column<string>(nullable: false),
                    Cuidados = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FichaTecnica", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Fornecedor",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    DataCadastro = table.Column<DateTime>(nullable: false),
                    CNPJ = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fornecedor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GrupoPrecificacao",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    DataCadastro = table.Column<DateTime>(nullable: false),
                    MargemMin = table.Column<int>(nullable: false),
                    MargemMax = table.Column<int>(nullable: false),
                    TipoGrupoPrecificacao = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GrupoPrecificacao", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Produto",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: false),
                    Modelo = table.Column<string>(nullable: false),
                    Valor = table.Column<double>(nullable: false),
                    CodigoBarra = table.Column<string>(nullable: false),
                    URLFoto = table.Column<string>(nullable: false),
                    Descricao = table.Column<string>(nullable: false),
                    Quantidade = table.Column<int>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    DataCadastro = table.Column<DateTime>(nullable: false),
                    GrupoPrecificacaoId = table.Column<int>(nullable: false),
                    FornecedorId = table.Column<int>(nullable: false),
                    Marca = table.Column<int>(nullable: false),
                    CorPrimariaProduto = table.Column<int>(nullable: false),
                    CorSecundariaProduto = table.Column<int>(nullable: false),
                    Genero = table.Column<int>(nullable: false),
                    Tamanho = table.Column<int>(nullable: false),
                    FichaTecnicaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Produto_FichaTecnica_FichaTecnicaId",
                        column: x => x.FichaTecnicaId,
                        principalTable: "FichaTecnica",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Produto_Fornecedor_FornecedorId",
                        column: x => x.FornecedorId,
                        principalTable: "Fornecedor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Produto_GrupoPrecificacao_GrupoPrecificacaoId",
                        column: x => x.GrupoPrecificacaoId,
                        principalTable: "GrupoPrecificacao",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Categoria",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    DataCadastro = table.Column<DateTime>(nullable: false),
                    ProdutoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categoria", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Categoria_Produto_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "Produto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Categoria_ProdutoId",
                table: "Categoria",
                column: "ProdutoId");

            migrationBuilder.CreateIndex(
                name: "IX_Produto_FichaTecnicaId",
                table: "Produto",
                column: "FichaTecnicaId");

            migrationBuilder.CreateIndex(
                name: "IX_Produto_FornecedorId",
                table: "Produto",
                column: "FornecedorId");

            migrationBuilder.CreateIndex(
                name: "IX_Produto_GrupoPrecificacaoId",
                table: "Produto",
                column: "GrupoPrecificacaoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categoria");

            migrationBuilder.DropTable(
                name: "Produto");

            migrationBuilder.DropTable(
                name: "FichaTecnica");

            migrationBuilder.DropTable(
                name: "Fornecedor");

            migrationBuilder.DropTable(
                name: "GrupoPrecificacao");
        }
    }
}
