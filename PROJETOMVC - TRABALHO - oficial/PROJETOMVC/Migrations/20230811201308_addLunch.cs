using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PROJETOMVC.Migrations
{
    /// <inheritdoc />
    public partial class addLunch : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //aqui iremo primeiro passar o CategoryId que é a chave estrangeira, e não o ID da tabela.
            migrationBuilder.Sql("INSERT INTO Lanches(CategoryId, Name, ShortDescription, LongDescription, Price, ImageURL, ImageThumbUR, Preferred, InStock) " +
                "VALUES(2,'Chesse Burguer', 'Um hamburguer delicioso com muito queijo', 'Pão, queijo, hamburguer de 150 e muita alegria e gostosura', 25.50, 'adicionar depois', 'adicionar depois', 1, 1)");

            migrationBuilder.Sql("INSERT INTO Lanches(CategoryId, Name, ShortDescription, LongDescription, Price, ImageURL, ImageThumbUR, Preferred, InStock) " +
               "VALUES(3,'sanduiche natural', 'Um lanche natural', 'Pão, queijo, frango desfiado, tomate e alface', 14.90, 'adicionar depois', 'adicionar depois', 0, 1)");

            migrationBuilder.Sql("INSERT INTO Lanches(CategoryId, Name, ShortDescription, LongDescription, Price, ImageURL, ImageThumbUR, Preferred, InStock) " +
               "VALUES(2,'xbacon', 'Um hamburguer delicioso com muito bacon', 'Pão, queijo, hamburguer de 120g, bacon, cebola roxa e maionese especial', 25.50, 'adicionar depois', 'adicionar depois', 0, 1)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Lanches");
        }
    }
}
