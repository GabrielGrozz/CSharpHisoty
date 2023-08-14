using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PROJETOMVC.Migrations
{
    /// <inheritdoc />
    public partial class PovoandoLunchs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //aqui é necessário que passemos a chave estrangeira refente a nossa tabela categorias

            migrationBuilder.Sql("INSERT INTO Lanches(CategoryId, Name, ShortDescription, LongDescription, Price, ImageURL, ImageThumbUR, Preferred, InStock) " +
                "VALUES (4, 'Cheeseburger', 'Um chesseburguer', 'pão, hamburguer de 150g, muito queijo, e acomopanha uma porção de batatas P', 25.50, 'adicionar depois', 'adicionar depois', 1, 1)");

            migrationBuilder.Sql("INSERT INTO Lanches(CategoryId, Name, ShortDescription, LongDescription, Price, ImageURL, ImageThumbUR, Preferred, InStock) " +
               "VALUES (4, 'X-Bacon', 'Um hamburguer com bacon', 'pão, hamburguer de 130g, bacon, alface, tomate, picles, maionese da casa', 29.99, 'adicionar depois', 'adicionar depois', 0, 1)");

            migrationBuilder.Sql("INSERT INTO Lanches(CategoryId, Name, ShortDescription, LongDescription, Price, ImageURL, ImageThumbUR, Preferred, InStock) " +
                "VALUES (5, 'Sanduiche vegano', 'Um sanduiche natural e vegano', 'pão, hamburguer de proiteina de soja, alface, tomate e picles', 28.00, 'adicionar depois', 'adicionar depois', 0, 1)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Lanches");
        }
    }
}
