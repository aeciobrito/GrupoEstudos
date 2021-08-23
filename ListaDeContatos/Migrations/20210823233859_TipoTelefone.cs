using Microsoft.EntityFrameworkCore.Migrations;

namespace ListaDeContatos.Migrations
{
    public partial class TipoTelefone : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Telefone",
                table: "Contatos",
                newName: "Telefone_Numero");

            migrationBuilder.AddColumn<string>(
                name: "Telefone_Ddd",
                table: "Contatos",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Telefone_Ddd",
                table: "Contatos");

            migrationBuilder.RenameColumn(
                name: "Telefone_Numero",
                table: "Contatos",
                newName: "Telefone");
        }
    }
}
