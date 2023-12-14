using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HexaLingo.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Words",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IconPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsFavorite = table.Column<bool>(type: "bit", nullable: false),
                    PolishLang = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnglishLang = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpanishLang = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GermanishLang = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ItalianishLang = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FrenchLang = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SentencePolishLang = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SentenceEnglishLang = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SentenceSpanishLang = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SentenceGermanishLang = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SentenceItalianishLang = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SentenceFrenchLang = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Words", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Words");
        }
    }
}
