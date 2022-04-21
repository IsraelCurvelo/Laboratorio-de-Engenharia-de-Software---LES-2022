using Microsoft.EntityFrameworkCore.Migrations;

namespace RaellShoes.Migrations
{
    public partial class _2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pedido_Cliente_ClienteId",
                table: "Pedido");

            migrationBuilder.DropForeignKey(
                name: "FK_Pedido_Cupom_CupomId",
                table: "Pedido");

            migrationBuilder.DropIndex(
                name: "IX_Pedido_ClienteId",
                table: "Pedido");

            migrationBuilder.DropColumn(
                name: "ClienteId",
                table: "Pedido");

            migrationBuilder.RenameColumn(
                name: "CupomId",
                table: "Pedido",
                newName: "ClienteId1");

            migrationBuilder.RenameIndex(
                name: "IX_Pedido_CupomId",
                table: "Pedido",
                newName: "IX_Pedido_ClienteId1");

            migrationBuilder.AddColumn<int>(
                name: "CupomId1",
                table: "Pedido",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pedido_CupomId1",
                table: "Pedido",
                column: "CupomId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Pedido_Cliente_ClienteId1",
                table: "Pedido",
                column: "ClienteId1",
                principalTable: "Cliente",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pedido_Cupom_CupomId1",
                table: "Pedido",
                column: "CupomId1",
                principalTable: "Cupom",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pedido_Cliente_ClienteId1",
                table: "Pedido");

            migrationBuilder.DropForeignKey(
                name: "FK_Pedido_Cupom_CupomId1",
                table: "Pedido");

            migrationBuilder.DropIndex(
                name: "IX_Pedido_CupomId1",
                table: "Pedido");

            migrationBuilder.DropColumn(
                name: "CupomId1",
                table: "Pedido");

            migrationBuilder.RenameColumn(
                name: "ClienteId1",
                table: "Pedido",
                newName: "CupomId");

            migrationBuilder.RenameIndex(
                name: "IX_Pedido_ClienteId1",
                table: "Pedido",
                newName: "IX_Pedido_CupomId");

            migrationBuilder.AddColumn<int>(
                name: "ClienteId",
                table: "Pedido",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Pedido_ClienteId",
                table: "Pedido",
                column: "ClienteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pedido_Cliente_ClienteId",
                table: "Pedido",
                column: "ClienteId",
                principalTable: "Cliente",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pedido_Cupom_CupomId",
                table: "Pedido",
                column: "CupomId",
                principalTable: "Cupom",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
