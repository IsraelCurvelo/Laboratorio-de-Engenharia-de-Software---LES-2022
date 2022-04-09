using Microsoft.EntityFrameworkCore.Migrations;

namespace RaellShoes.Migrations
{
    public partial class Cupom : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Desconto",
                table: "Cupom",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Desconto",
                table: "Cupom");
        }
    }
}
