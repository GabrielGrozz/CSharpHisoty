using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace baseProjeto.Migrations
{
    /// <inheritdoc />
    public partial class AddCategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Categorias(Name, Description) " +
                           "VALUES('Normal','Lanche utilizando ingredientes normais')");

            migrationBuilder.Sql("INSERT INTO Categorias(Name, Description) " +
                "VALUES('Natural','Lanche feito com ingrediente naturais e integrais')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Categorias");
        }
    }
}
