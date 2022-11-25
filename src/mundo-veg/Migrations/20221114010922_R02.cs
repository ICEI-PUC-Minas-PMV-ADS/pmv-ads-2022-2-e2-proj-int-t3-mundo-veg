using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace mundo_veg.Migrations
{
    public partial class R02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClienteId",
                table: "Receitas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Receitas_ClienteId",
                table: "Receitas",
                column: "ClienteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Receitas_Usuários: Pessoa Física_ClienteId",
                table: "Receitas",
                column: "ClienteId",
                principalTable: "Usuários: Pessoa Física",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Receitas_Usuários: Pessoa Física_ClienteId",
                table: "Receitas");

            migrationBuilder.DropIndex(
                name: "IX_Receitas_ClienteId",
                table: "Receitas");

            migrationBuilder.DropColumn(
                name: "ClienteId",
                table: "Receitas");
        }
    }
}
