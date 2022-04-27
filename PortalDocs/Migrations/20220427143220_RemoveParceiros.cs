using Microsoft.EntityFrameworkCore.Migrations;

namespace PortalDocs.Migrations
{
    public partial class RemoveParceiros : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Solicitacoes_Parceiros_ParceiroId",
                table: "Solicitacoes");

            migrationBuilder.DropTable(
                name: "Parceiros");

            migrationBuilder.DropIndex(
                name: "IX_Solicitacoes_ParceiroId",
                table: "Solicitacoes");

            migrationBuilder.DropColumn(
                name: "ParceiroId",
                table: "Solicitacoes");

            migrationBuilder.AddColumn<string>(
                name: "ParceiroCnpj",
                table: "Solicitacoes",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ParceiroEmail",
                table: "Solicitacoes",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ParceiroNome",
                table: "Solicitacoes",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ParceiroCnpj",
                table: "Solicitacoes");

            migrationBuilder.DropColumn(
                name: "ParceiroEmail",
                table: "Solicitacoes");

            migrationBuilder.DropColumn(
                name: "ParceiroNome",
                table: "Solicitacoes");

            migrationBuilder.AddColumn<int>(
                name: "ParceiroId",
                table: "Solicitacoes",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Parceiros",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CNPJ = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    Nome = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parceiros", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Solicitacoes_ParceiroId",
                table: "Solicitacoes",
                column: "ParceiroId");

            migrationBuilder.AddForeignKey(
                name: "FK_Solicitacoes_Parceiros_ParceiroId",
                table: "Solicitacoes",
                column: "ParceiroId",
                principalTable: "Parceiros",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
