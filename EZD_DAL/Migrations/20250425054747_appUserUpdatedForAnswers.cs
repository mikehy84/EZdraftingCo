using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EZD_DAL.Migrations
{
    /// <inheritdoc />
    public partial class appUserUpdatedForAnswers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AnswerFirst",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AnswerSecond",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AnswerFirst",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "AnswerSecond",
                table: "AspNetUsers");
        }
    }
}
