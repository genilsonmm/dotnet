using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Quiz.API.Migrations
{
    /// <inheritdoc />
    public partial class answers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Value",
                table: "Answers",
                newName: "ValueE");

            migrationBuilder.AddColumn<string>(
                name: "AnswerValue",
                table: "Answers",
                type: "varchar(2)",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "ValueA",
                table: "Answers",
                type: "varchar(300)",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "ValueB",
                table: "Answers",
                type: "varchar(300)",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "ValueC",
                table: "Answers",
                type: "varchar(300)",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "ValueD",
                table: "Answers",
                type: "varchar(300)",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AnswerValue",
                table: "Answers");

            migrationBuilder.DropColumn(
                name: "ValueA",
                table: "Answers");

            migrationBuilder.DropColumn(
                name: "ValueB",
                table: "Answers");

            migrationBuilder.DropColumn(
                name: "ValueC",
                table: "Answers");

            migrationBuilder.DropColumn(
                name: "ValueD",
                table: "Answers");

            migrationBuilder.RenameColumn(
                name: "ValueE",
                table: "Answers",
                newName: "Value");
        }
    }
}
