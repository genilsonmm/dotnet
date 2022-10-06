using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Quiz.DATA.Migrations
{
    public partial class updatequestoes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Questoes",
                table: "Questoes");

            migrationBuilder.RenameTable(
                name: "Questoes",
                newName: "Questao");

            migrationBuilder.UpdateData(
                table: "Questao",
                keyColumn: "Titulo",
                keyValue: null,
                column: "Titulo",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Titulo",
                table: "Questao",
                type: "varchar(100)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Questao",
                keyColumn: "AlternativaE",
                keyValue: null,
                column: "AlternativaE",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "AlternativaE",
                table: "Questao",
                type: "varchar(150)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Questao",
                keyColumn: "AlternativaD",
                keyValue: null,
                column: "AlternativaD",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "AlternativaD",
                table: "Questao",
                type: "varchar(150)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Questao",
                keyColumn: "AlternativaC",
                keyValue: null,
                column: "AlternativaC",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "AlternativaC",
                table: "Questao",
                type: "varchar(150)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Questao",
                keyColumn: "AlternativaB",
                keyValue: null,
                column: "AlternativaB",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "AlternativaB",
                table: "Questao",
                type: "varchar(150)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Questao",
                keyColumn: "AlternativaA",
                keyValue: null,
                column: "AlternativaA",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "AlternativaA",
                table: "Questao",
                type: "varchar(150)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Questao",
                table: "Questao",
                column: "QuestaoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Questao",
                table: "Questao");

            migrationBuilder.RenameTable(
                name: "Questao",
                newName: "Questoes");

            migrationBuilder.AlterColumn<string>(
                name: "Titulo",
                table: "Questoes",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "AlternativaE",
                table: "Questoes",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(150)")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "AlternativaD",
                table: "Questoes",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(150)")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "AlternativaC",
                table: "Questoes",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(150)")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "AlternativaB",
                table: "Questoes",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(150)")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "AlternativaA",
                table: "Questoes",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(150)")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Questoes",
                table: "Questoes",
                column: "QuestaoId");
        }
    }
}
