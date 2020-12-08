using Microsoft.EntityFrameworkCore.Migrations;

namespace cadastroCliente.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "cliente",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    nomeCliente = table.Column<string>(nullable: true),
                    telefone = table.Column<string>(nullable: true),
                    rg = table.Column<string>(nullable: true),
                    endereco = table.Column<string>(nullable: true),
                    cpf = table.Column<string>(nullable: true),
                    email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cliente", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "cliente");
        }
    }
}
