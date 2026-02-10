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
                name: "japaneseGojuuonCharacters",
                columns: table => new
                {
                    Unicode = table.Column<string>(type: "TEXT", nullable: false),
                    Japanese = table.Column<string>(type: "TEXT", nullable: false),
                    Roman = table.Column<string>(type: "TEXT", nullable: false),
                    isNative = table.Column<bool>(type: "INTEGER", nullable: false),
                    isDakuten = table.Column<bool>(type: "INTEGER", nullable: false),
                    isSutegana = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_japaneseGojuuonCharacters", x => x.Unicode);
                });

            migrationBuilder.CreateTable(
                name: "japaneseYouonCharacters",
                columns: table => new
                {
                    Unicode = table.Column<string>(type: "TEXT", nullable: false),
                    JapaneseBase = table.Column<string>(type: "TEXT", nullable: false),
                    JapaneseAddon = table.Column<string>(type: "TEXT", nullable: false),
                    Roman = table.Column<string>(type: "TEXT", nullable: false),
                    isNative = table.Column<bool>(type: "INTEGER", nullable: false),
                    isDakuten = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_japaneseYouonCharacters", x => x.Unicode);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "japaneseGojuuonCharacters");

            migrationBuilder.DropTable(
                name: "japaneseYouonCharacters");
        }
    }
}
