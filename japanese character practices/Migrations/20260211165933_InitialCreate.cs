using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace japanese_character_practices.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GojuuonHiragana",
                columns: table => new
                {
                    Unicode = table.Column<string>(type: "TEXT", nullable: false),
                    Japanese = table.Column<string>(type: "TEXT", nullable: false),
                    Roman = table.Column<string>(type: "TEXT", nullable: false),
                    IsDakuten = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GojuuonHiragana", x => x.Unicode);
                });

            migrationBuilder.CreateTable(
                name: "GojuuonKatakana",
                columns: table => new
                {
                    Unicode = table.Column<string>(type: "TEXT", nullable: false),
                    Japanese = table.Column<string>(type: "TEXT", nullable: false),
                    Roman = table.Column<string>(type: "TEXT", nullable: false),
                    IsDakuten = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GojuuonKatakana", x => x.Unicode);
                });

            migrationBuilder.CreateTable(
                name: "SuteganaHiragana",
                columns: table => new
                {
                    Unicode = table.Column<string>(type: "TEXT", nullable: false),
                    Japanese = table.Column<string>(type: "TEXT", nullable: false),
                    Roman = table.Column<string>(type: "TEXT", nullable: false),
                    IsDakuten = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SuteganaHiragana", x => x.Unicode);
                });

            migrationBuilder.CreateTable(
                name: "SuteganaKatakana",
                columns: table => new
                {
                    Unicode = table.Column<string>(type: "TEXT", nullable: false),
                    Japanese = table.Column<string>(type: "TEXT", nullable: false),
                    Roman = table.Column<string>(type: "TEXT", nullable: false),
                    IsDakuten = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SuteganaKatakana", x => x.Unicode);
                });

            migrationBuilder.CreateTable(
                name: "YouonHiragana",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UnicodeBase = table.Column<string>(type: "TEXT", nullable: false),
                    Roman = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YouonHiragana", x => x.Id);
                    table.ForeignKey(
                        name: "FK_YouonHiragana_GojuuonHiragana_UnicodeBase",
                        column: x => x.UnicodeBase,
                        principalTable: "GojuuonHiragana",
                        principalColumn: "Unicode",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "YouonKatakana",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UnicodeBase = table.Column<string>(type: "TEXT", nullable: false),
                    Roman = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YouonKatakana", x => x.Id);
                    table.ForeignKey(
                        name: "FK_YouonKatakana_GojuuonKatakana_UnicodeBase",
                        column: x => x.UnicodeBase,
                        principalTable: "GojuuonKatakana",
                        principalColumn: "Unicode",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SuteganaHiraganaYouonHiragana",
                columns: table => new
                {
                    SuteganaHiraganasUnicode = table.Column<string>(type: "TEXT", nullable: false),
                    YouonHiraganaId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SuteganaHiraganaYouonHiragana", x => new { x.SuteganaHiraganasUnicode, x.YouonHiraganaId });
                    table.ForeignKey(
                        name: "FK_SuteganaHiraganaYouonHiragana_SuteganaHiragana_SuteganaHiraganasUnicode",
                        column: x => x.SuteganaHiraganasUnicode,
                        principalTable: "SuteganaHiragana",
                        principalColumn: "Unicode",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SuteganaHiraganaYouonHiragana_YouonHiragana_YouonHiraganaId",
                        column: x => x.YouonHiraganaId,
                        principalTable: "YouonHiragana",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SuteganaKatakanaYouonKatakana",
                columns: table => new
                {
                    SuteganaKatakanasUnicode = table.Column<string>(type: "TEXT", nullable: false),
                    YouonKatakanaId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SuteganaKatakanaYouonKatakana", x => new { x.SuteganaKatakanasUnicode, x.YouonKatakanaId });
                    table.ForeignKey(
                        name: "FK_SuteganaKatakanaYouonKatakana_SuteganaKatakana_SuteganaKatakanasUnicode",
                        column: x => x.SuteganaKatakanasUnicode,
                        principalTable: "SuteganaKatakana",
                        principalColumn: "Unicode",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SuteganaKatakanaYouonKatakana_YouonKatakana_YouonKatakanaId",
                        column: x => x.YouonKatakanaId,
                        principalTable: "YouonKatakana",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SuteganaHiraganaYouonHiragana_YouonHiraganaId",
                table: "SuteganaHiraganaYouonHiragana",
                column: "YouonHiraganaId");

            migrationBuilder.CreateIndex(
                name: "IX_SuteganaKatakanaYouonKatakana_YouonKatakanaId",
                table: "SuteganaKatakanaYouonKatakana",
                column: "YouonKatakanaId");

            migrationBuilder.CreateIndex(
                name: "IX_YouonHiragana_UnicodeBase",
                table: "YouonHiragana",
                column: "UnicodeBase");

            migrationBuilder.CreateIndex(
                name: "IX_YouonKatakana_UnicodeBase",
                table: "YouonKatakana",
                column: "UnicodeBase");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SuteganaHiraganaYouonHiragana");

            migrationBuilder.DropTable(
                name: "SuteganaKatakanaYouonKatakana");

            migrationBuilder.DropTable(
                name: "SuteganaHiragana");

            migrationBuilder.DropTable(
                name: "YouonHiragana");

            migrationBuilder.DropTable(
                name: "SuteganaKatakana");

            migrationBuilder.DropTable(
                name: "YouonKatakana");

            migrationBuilder.DropTable(
                name: "GojuuonHiragana");

            migrationBuilder.DropTable(
                name: "GojuuonKatakana");
        }
    }
}
