using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FirstApp.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "dictionaries",
                columns: table => new
                {
                    dictionaryid = table.Column<int>(name: "dictionary_id", type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    weakwords = table.Column<int>(name: "weak_words", type: "int(11)", nullable: true),
                    middlewords = table.Column<int>(name: "middle_words", type: "int(11)", nullable: true),
                    strongwords = table.Column<int>(name: "strong_words", type: "int(11)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.dictionaryid);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_unicode_ci");

            migrationBuilder.CreateTable(
                name: "words",
                columns: table => new
                {
                    wordid = table.Column<int>(name: "word_id", type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    word = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true, collation: "utf8mb4_unicode_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    translate = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true, collation: "utf8mb4_unicode_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.wordid);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_unicode_ci");

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    userid = table.Column<int>(name: "user_id", type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    username = table.Column<string>(name: "user_name", type: "varchar(50)", maxLength: 50, nullable: true, collation: "utf8mb4_unicode_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    userpassword = table.Column<string>(name: "user_password", type: "varchar(30)", maxLength: 30, nullable: true, collation: "utf8mb4_unicode_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    dictionaryid = table.Column<int>(name: "dictionary_id", type: "int(11)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.userid);
                    table.ForeignKey(
                        name: "users_ibfk_1",
                        column: x => x.dictionaryid,
                        principalTable: "dictionaries",
                        principalColumn: "dictionary_id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_unicode_ci");

            migrationBuilder.CreateTable(
                name: "wordsdictionaries",
                columns: table => new
                {
                    wordDictionaryid = table.Column<int>(name: "wordDictionary_id", type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    dictionaryid = table.Column<int>(name: "dictionary_id", type: "int(11)", nullable: true),
                    wordid = table.Column<int>(name: "word_id", type: "int(11)", nullable: true),
                    progres = table.Column<int>(type: "int(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.wordDictionaryid);
                    table.ForeignKey(
                        name: "wordsdictionaries_ibfk_1",
                        column: x => x.dictionaryid,
                        principalTable: "dictionaries",
                        principalColumn: "dictionary_id");
                    table.ForeignKey(
                        name: "wordsdictionaries_ibfk_2",
                        column: x => x.wordid,
                        principalTable: "words",
                        principalColumn: "word_id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_unicode_ci");

            migrationBuilder.CreateIndex(
                name: "dictionary_id",
                table: "users",
                column: "dictionary_id");

            migrationBuilder.CreateIndex(
                name: "user_name",
                table: "users",
                column: "user_name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "word",
                table: "words",
                column: "word",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "dictionary_id1",
                table: "wordsdictionaries",
                column: "dictionary_id");

            migrationBuilder.CreateIndex(
                name: "word_id",
                table: "wordsdictionaries",
                column: "word_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "users");

            migrationBuilder.DropTable(
                name: "wordsdictionaries");

            migrationBuilder.DropTable(
                name: "dictionaries");

            migrationBuilder.DropTable(
                name: "words");
        }
    }
}
