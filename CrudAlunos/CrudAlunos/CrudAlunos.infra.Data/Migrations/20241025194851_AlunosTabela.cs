using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CrudAlunos.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class AlunosTabela : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Alunos",
                columns: table => new
                {
                    NMatricula = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NomeAluno = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    NomeResponsavel = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Telefone = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Cpf = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Cep = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Endereco = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Bairro = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Cidade = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    NumeroCasa = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alunos", x => x.NMatricula);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Alunos");
        }
    }
}
