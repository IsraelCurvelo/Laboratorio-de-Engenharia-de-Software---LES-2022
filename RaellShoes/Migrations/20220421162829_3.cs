using Microsoft.EntityFrameworkCore.Migrations;

namespace RaellShoes.Migrations
{
    public partial class _3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pedido_Cliente_ClienteId1",
                table: "Pedido");

            migrationBuilder.RenameColumn(
                name: "ClienteId1",
                table: "Pedido",
                newName: "ClienteId");

            migrationBuilder.RenameIndex(
                name: "IX_Pedido_ClienteId1",
                table: "Pedido",
                newName: "IX_Pedido_ClienteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pedido_Cliente_ClienteId",
                table: "Pedido",
                column: "ClienteId",
                principalTable: "Cliente",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pedido_Cliente_ClienteId",
                table: "Pedido");

            migrationBuilder.RenameColumn(
                name: "ClienteId",
                table: "Pedido",
                newName: "ClienteId1");

            migrationBuilder.RenameIndex(
                name: "IX_Pedido_ClienteId",
                table: "Pedido",
                newName: "IX_Pedido_ClienteId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Pedido_Cliente_ClienteId1",
                table: "Pedido",
                column: "ClienteId1",
                principalTable: "Cliente",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
