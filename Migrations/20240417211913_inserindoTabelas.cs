using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Investify.Migrations
{
    /// <inheritdoc />
    public partial class inserindoTabelas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cargo",
                columns: table => new
                {
                    Car_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Car_nome = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cargo", x => x.Car_id);
                });

            migrationBuilder.CreateTable(
                name: "Carteira",
                columns: table => new
                {
                    Crt_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Crt_ideia = table.Column<int>(type: "int", nullable: false),
                    Crt_investidor = table.Column<int>(type: "int", nullable: false),
                    Crt_valorInvestido = table.Column<double>(type: "float", nullable: false),
                    Crt_dataInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Crt_participacao = table.Column<int>(type: "int", nullable: false),
                    Crt_receita = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carteira", x => x.Crt_id);
                });

            migrationBuilder.CreateTable(
                name: "Genero",
                columns: table => new
                {
                    Gen_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Gen_nome = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genero", x => x.Gen_id);
                });

            migrationBuilder.CreateTable(
                name: "Ideia",
                columns: table => new
                {
                    Ide_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ide_nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ide_descricao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ide_empresario = table.Column<int>(type: "int", nullable: false),
                    Ide_nivelRisco = table.Column<int>(type: "int", nullable: false),
                    Ide_tipo = table.Column<int>(type: "int", nullable: false),
                    Ide_cnpj = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ide_fase = table.Column<int>(type: "int", nullable: false),
                    Ide_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Ide_status = table.Column<int>(type: "int", nullable: false),
                    Ide_valorInicial = table.Column<double>(type: "float", nullable: false),
                    Ide_valorAtual = table.Column<double>(type: "float", nullable: false),
                    Ide_participacaoDisponivel = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ideia", x => x.Ide_id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cargo");

            migrationBuilder.DropTable(
                name: "Carteira");

            migrationBuilder.DropTable(
                name: "Genero");

            migrationBuilder.DropTable(
                name: "Ideia");
        }
    }
}
