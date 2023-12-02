using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Library.Migrations
{
    public partial class CreateDB7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoriesBooks");

            migrationBuilder.CreateTable(
                name: "GenreBooks",
                columns: table => new
                {
                    BookId = table.Column<int>(type: "int", nullable: false),
                    GenreId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GenreBooks", x => new { x.BookId, x.GenreId });
                    table.ForeignKey(
                        name: "FK_GenreBooks_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GenreBooks_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_GenreBooks_GenreId",
                table: "GenreBooks",
                column: "GenreId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GenreBooks");

            migrationBuilder.CreateTable(
                name: "CategoriesBooks",
                columns: table => new
                {
                    BookId = table.Column<int>(type: "int", nullable: false),
                    CategorieId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    BookName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CategorieName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoriesBooks", x => new { x.BookId, x.CategorieId });
                    table.ForeignKey(
                        name: "FK_CategoriesBooks_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoriesBooks_Genres_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriesBooks_CategoryId",
                table: "CategoriesBooks",
                column: "CategoryId");
        }
    }
}
