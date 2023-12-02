using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Library.Migrations
{
    public partial class changegenrebooks1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_GenreBook_GenreBookBookName_GenreBookGenreName",
                table: "Books");

            migrationBuilder.DropForeignKey(
                name: "FK_GenreBook_Books_BookName",
                table: "GenreBook");

            migrationBuilder.DropForeignKey(
                name: "FK_GenreBook_Genre_GenreName",
                table: "GenreBook");

            migrationBuilder.DropIndex(
                name: "IX_Books_GenreBookBookName_GenreBookGenreName",
                table: "Books");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GenreBook",
                table: "GenreBook");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Genre",
                table: "Genre");

            migrationBuilder.DropColumn(
                name: "GenreBookBookName",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "GenreBookGenreName",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "GenreName",
                table: "Books");

            migrationBuilder.RenameTable(
                name: "GenreBook",
                newName: "GenreBooks");

            migrationBuilder.RenameTable(
                name: "Genre",
                newName: "Genres");

            migrationBuilder.RenameColumn(
                name: "GenreName",
                table: "GenreBooks",
                newName: "GenreId");

            migrationBuilder.RenameColumn(
                name: "BookName",
                table: "GenreBooks",
                newName: "BookId");

            migrationBuilder.RenameIndex(
                name: "IX_GenreBook_GenreName",
                table: "GenreBooks",
                newName: "IX_GenreBooks_GenreId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GenreBooks",
                table: "GenreBooks",
                columns: new[] { "BookId", "GenreId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Genres",
                table: "Genres",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GenreBooks_Books_BookId",
                table: "GenreBooks",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GenreBooks_Genres_GenreId",
                table: "GenreBooks",
                column: "GenreId",
                principalTable: "Genres",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GenreBooks_Books_BookId",
                table: "GenreBooks");

            migrationBuilder.DropForeignKey(
                name: "FK_GenreBooks_Genres_GenreId",
                table: "GenreBooks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Genres",
                table: "Genres");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GenreBooks",
                table: "GenreBooks");

            migrationBuilder.RenameTable(
                name: "Genres",
                newName: "Genre");

            migrationBuilder.RenameTable(
                name: "GenreBooks",
                newName: "GenreBook");

            migrationBuilder.RenameColumn(
                name: "GenreId",
                table: "GenreBook",
                newName: "GenreName");

            migrationBuilder.RenameColumn(
                name: "BookId",
                table: "GenreBook",
                newName: "BookName");

            migrationBuilder.RenameIndex(
                name: "IX_GenreBooks_GenreId",
                table: "GenreBook",
                newName: "IX_GenreBook_GenreName");

            migrationBuilder.AddColumn<int>(
                name: "GenreBookBookName",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GenreBookGenreName",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "GenreName",
                table: "Books",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Genre",
                table: "Genre",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GenreBook",
                table: "GenreBook",
                columns: new[] { "BookName", "GenreName" });

            migrationBuilder.CreateIndex(
                name: "IX_Books_GenreBookBookName_GenreBookGenreName",
                table: "Books",
                columns: new[] { "GenreBookBookName", "GenreBookGenreName" });

            migrationBuilder.AddForeignKey(
                name: "FK_Books_GenreBook_GenreBookBookName_GenreBookGenreName",
                table: "Books",
                columns: new[] { "GenreBookBookName", "GenreBookGenreName" },
                principalTable: "GenreBook",
                principalColumns: new[] { "BookName", "GenreName" },
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GenreBook_Books_BookName",
                table: "GenreBook",
                column: "BookName",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GenreBook_Genre_GenreName",
                table: "GenreBook",
                column: "GenreName",
                principalTable: "Genre",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
