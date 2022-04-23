using Microsoft.EntityFrameworkCore.Migrations;

namespace RaellShoes.Migrations
{
    public partial class TrocaClien : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Troca_Cliente_ClienteId",
                table: "Troca");

            migrationBuilder.DropIndex(
                name: "IX_Troca_ClienteId",
                table: "Troca");

            migrationBuilder.DropColumn(
                name: "ClienteId",
                table: "Troca");

            migrationBuilder.AddColumn<int>(
                name: "IddoCliente",
                table: "Troca",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IddoCliente",
                table: "Troca");

            migrationBuilder.AddColumn<int>(
                name: "ClienteId",
                table: "Troca",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Troca_ClienteId",
                table: "Troca",
                column: "ClienteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Troca_Cliente_ClienteId",
                table: "Troca",
                column: "ClienteId",
                principalTable: "Cliente",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
