using Microsoft.EntityFrameworkCore.Migrations;

namespace ListaDeContatos.Migrations
{
    public partial class TipoEndereco : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Rua",
                table: "Contatos",
                newName: "Endereco_Rua");

            migrationBuilder.RenameColumn(
                name: "Bairro",
                table: "Contatos",
                newName: "Endereco_Bairro");

            migrationBuilder.RenameColumn(
                name: "NumeroDaResidencia",
                table: "Contatos",
                newName: "Endereco_Numero");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Endereco_Rua",
                table: "Contatos",
                newName: "Rua");

            migrationBuilder.RenameColumn(
                name: "Endereco_Bairro",
                table: "Contatos",
                newName: "Bairro");

            migrationBuilder.RenameColumn(
                name: "Endereco_Numero",
                table: "Contatos",
                newName: "NumeroDaResidencia");
        }
    }
}
