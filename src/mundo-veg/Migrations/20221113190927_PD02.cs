using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace mundo_veg.Migrations
{
    public partial class PD02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Contato",
                table: "usuarios_pessoa_juridica");

            migrationBuilder.AddColumn<int>(
                name: "EstabelecimentoId",
                table: "Produtos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_EstabelecimentoId",
                table: "Produtos",
                column: "EstabelecimentoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Produtos_usuarios_pessoa_juridica_EstabelecimentoId",
                table: "Produtos",
                column: "EstabelecimentoId",
                principalTable: "usuarios_pessoa_juridica",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_usuarios_pessoa_juridica_EstabelecimentoId",
                table: "Produtos");

            migrationBuilder.DropIndex(
                name: "IX_Produtos_EstabelecimentoId",
                table: "Produtos");

            migrationBuilder.DropColumn(
                name: "EstabelecimentoId",
                table: "Produtos");

            migrationBuilder.AddColumn<string>(
                name: "Contato",
                table: "usuarios_pessoa_juridica",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
