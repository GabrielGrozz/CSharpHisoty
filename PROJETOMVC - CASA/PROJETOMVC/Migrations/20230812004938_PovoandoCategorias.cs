using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PROJETOMVC.Migrations
{
    /// <inheritdoc />
    public partial class PovoandoCategorias : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //com ess migration conseguimos adicionar os itens do banco de dados, lembrando que não é necessário colocar o ID, pois ele é gerenciado pelo banco de dados


            migrationBuilder.Sql("INSERT INTO Categorias(Name, Description) " +
                "VALUES ('Normal', 'Um lanche com ingredientes normais')");

            migrationBuilder.Sql("INSERT INTO Categorias(Name, Description) " +
                "VALUES ('Natural', 'Um lanche com ingredientes naturais e orgânicos')");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //aqui passamos um delete from com o nome da tabela para caso queiramos deletar nossas atualizações, basta utilizar ele
            migrationBuilder.Sql("DELETE FROM Categorias");
        }
    }
}
