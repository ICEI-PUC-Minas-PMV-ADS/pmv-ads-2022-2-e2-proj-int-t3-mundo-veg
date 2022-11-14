using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace mundo_veg.Migrations
{
    public partial class PD03 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Ingredientes",
                table: "Produtos",
                newName: "Descricao");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Descricao",
                table: "Produtos",
                newName: "Ingredientes");
        }
    }
}
