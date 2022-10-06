using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Quiz.DATA.Migrations
{
    public partial class updatetablename : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Questao",
                table: "Questao");

            migrationBuilder.RenameTable(
                name: "Questao",
                newName: "Questoes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Questoes",
                table: "Questoes",
                column: "QuestaoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Questoes",
                table: "Questoes");

            migrationBuilder.RenameTable(
                name: "Questoes",
                newName: "Questao");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Questao",
                table: "Questao",
                column: "QuestaoId");
        }
    }
}
