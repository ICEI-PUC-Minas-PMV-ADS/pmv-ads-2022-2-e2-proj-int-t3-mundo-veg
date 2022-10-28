using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace mundo_veg.Migrations
{
    public partial class M02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Receitas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ingredientes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Modo_Preparo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rendimento = table.Column<int>(type: "int", nullable: false),
                    Dificuldade = table.Column<int>(type: "int", nullable: false),
                    Tempo_Preparo = table.Column<int>(type: "int", nullable: false),
                    Categoria = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Receitas", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Receitas");
        }
    }
}
