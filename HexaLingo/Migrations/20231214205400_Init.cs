using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

namespace HexaLingo.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Words",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Category = table.Column<string>(type: "longtext", nullable: true),
                    Language = table.Column<string>(type: "longtext", nullable: true),
                    IconPath = table.Column<string>(type: "longtext", nullable: true),
                    IsFavorite = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    PolishLang = table.Column<string>(type: "longtext", nullable: true),
                    EnglishLang = table.Column<string>(type: "longtext", nullable: true),
                    SpanishLang = table.Column<string>(type: "longtext", nullable: true),
                    GermanishLang = table.Column<string>(type: "longtext", nullable: true),
                    ItalianishLang = table.Column<string>(type: "longtext", nullable: true),
                    FrenchLang = table.Column<string>(type: "longtext", nullable: true),
                    SentencePolishLang = table.Column<string>(type: "longtext", nullable: true),
                    SentenceEnglishLang = table.Column<string>(type: "longtext", nullable: true),
                    SentenceSpanishLang = table.Column<string>(type: "longtext", nullable: true),
                    SentenceGermanishLang = table.Column<string>(type: "longtext", nullable: true),
                    SentenceItalianishLang = table.Column<string>(type: "longtext", nullable: true),
                    SentenceFrenchLang = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Words", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Words");
        }
    }
}
