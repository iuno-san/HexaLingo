using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HexaLingo.Migrations
{
    /// <inheritdoc />
    public partial class AddedLanguage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Language",
                table: "Words",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Language",
                table: "Words");
        }
    }
}
