using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RaellShoes.Migrations
{
    public partial class Troca : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Troca",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DataSolicitacao = table.Column<DateTime>(nullable: false),
                    ClienteId = table.Column<int>(nullable: true),
                    PedidoId = table.Column<int>(nullable: true),
                    ProdutoId = table.Column<int>(nullable: true),
                    TipoReembolso = table.Column<int>(nullable: false),
                    MetodoColeta = table.Column<int>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    MotivoTroca = table.Column<int>(nullable: false),
                    OutroMotivo = table.Column<string>(nullable: true),
                    Tamanho = table.Column<int>(nullable: false),
                    Comentarios = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Troca", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Troca_Cliente_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Cliente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Troca_Pedido_PedidoId",
                        column: x => x.PedidoId,
                        principalTable: "Pedido",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Troca_ProdutoPedido_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "ProdutoPedido",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Troca_ClienteId",
                table: "Troca",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Troca_PedidoId",
                table: "Troca",
                column: "PedidoId");

            migrationBuilder.CreateIndex(
                name: "IX_Troca_ProdutoId",
                table: "Troca",
                column: "ProdutoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Troca");
        }
    }
}
