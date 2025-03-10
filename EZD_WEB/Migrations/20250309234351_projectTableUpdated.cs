using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EZD_WEB.Migrations
{
    /// <inheritdoc />
    public partial class projectTableUpdated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BuildingName",
                table: "Projects",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "BuildingName", "Description", "ProjectName", "Weight" },
                values: new object[] { 1, "AUX", "It was a great job", "Parand Project", 2500 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "BuildingName",
                table: "Projects");
        }
    }
}
