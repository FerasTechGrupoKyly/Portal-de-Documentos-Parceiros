using Microsoft.EntityFrameworkCore.Migrations;

namespace PortalDocs.Migrations
{
    public partial class ParceirosNew : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Parceiros",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DocumentosEmpresa = table.Column<string>(type: "TEXT", nullable: true),
                    NomeFuncionario = table.Column<string>(type: "TEXT", nullable: true),
                    CpfFuncionario = table.Column<string>(type: "TEXT", nullable: true),
                    RgFuncionario = table.Column<string>(type: "TEXT", nullable: true),
                    DocumentosFuncionario = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parceiros", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Parceiros");
        }
    }
}
