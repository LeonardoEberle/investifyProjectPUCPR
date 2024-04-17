using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Investify.Migrations
{
    /// <inheritdoc />
    public partial class teste : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    Usu_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Usu_nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Usu_cpf = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Usu_senha = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Usu_telefone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Usu_email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Usu_dataInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Usu_dataNasc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Usu_status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.Usu_id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Usuario");
        }
    }
}
