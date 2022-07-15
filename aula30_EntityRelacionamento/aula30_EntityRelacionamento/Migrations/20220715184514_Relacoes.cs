using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace aula30_EntityRelacionamento.Migrations
{
    public partial class Relacoes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Instituicoes",
                table: "Instituicoes");

            migrationBuilder.RenameTable(
                name: "Instituicoes",
                newName: "Instituições");

            migrationBuilder.AddColumn<int>(
                name: "InstituicaoId",
                table: "Alunos",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Instituições",
                table: "Instituições",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Alunos_InstituicaoId",
                table: "Alunos",
                column: "InstituicaoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Alunos_Instituições_InstituicaoId",
                table: "Alunos",
                column: "InstituicaoId",
                principalTable: "Instituições",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Alunos_Instituições_InstituicaoId",
                table: "Alunos");

            migrationBuilder.DropIndex(
                name: "IX_Alunos_InstituicaoId",
                table: "Alunos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Instituições",
                table: "Instituições");

            migrationBuilder.DropColumn(
                name: "InstituicaoId",
                table: "Alunos");

            migrationBuilder.RenameTable(
                name: "Instituições",
                newName: "Instituicoes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Instituicoes",
                table: "Instituicoes",
                column: "Id");
        }
    }
}
