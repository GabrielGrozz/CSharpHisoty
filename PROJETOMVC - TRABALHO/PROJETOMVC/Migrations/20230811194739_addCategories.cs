﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PROJETOMVC.Migrations
{
    /// <inheritdoc />
    public partial class addCategories : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            //para popularmos uma tabela precisamo usar uma instancia de migrationBuilder e passarmos as seguintes instruções
            //o ID é gerenciado pelo banco de dados, então não é necessário inseri-lo
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
