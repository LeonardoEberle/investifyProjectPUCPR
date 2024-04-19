using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Investify.Migrations
{
    /// <inheritdoc />
    public partial class adicaoenum : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Usu_status",
                table: "Usuario",
                newName: "Usu_type");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Usu_type",
                table: "Usuario",
                newName: "Usu_status");
        }
    }
}
