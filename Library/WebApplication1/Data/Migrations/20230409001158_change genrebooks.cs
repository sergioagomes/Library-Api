using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Library.Migrations
{
    public partial class changegenrebooks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GenreBook_Books_BookId",
                table: "GenreBook");

            migrationBuilder.DropForeignKey(
                name: "FK_GenreBook_Books_BookId1",
                table: "GenreBook");

            migrationBuilder.DropForeignKey(
                name: "FK_GenreBook_Genre_GenreId",
                table: "GenreBook");

            migrationBuilder.DropIndex(
                name: "IX_GenreBook_BookId1",
                table: "GenreBook");

            migrationBuilder.DropColumn(
                name: "BookId1",
                table: "GenreBook");

            migrationBuilder.RenameColumn(
                name: "GenreId",
                table: "GenreBook",
                newName: "GenreName");

            migrationBuilder.RenameColumn(
                name: "BookId",
                table: "GenreBook",
                newName: "BookName");

            migrationBuilder.RenameIndex(
                name: "IX_GenreBook_GenreId",
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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "GenreBookBookName",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "GenreBookGenreName",
                table: "Books");

            migrationBuilder.RenameColumn(
                name: "GenreName",
                table: "GenreBook",
                newName: "GenreId");

            migrationBuilder.RenameColumn(
                name: "BookName",
                table: "GenreBook",
                newName: "BookId");

            migrationBuilder.RenameIndex(
                name: "IX_GenreBook_GenreName",
                table: "GenreBook",
                newName: "IX_GenreBook_GenreId");

            migrationBuilder.AddColumn<int>(
                name: "BookId1",
                table: "GenreBook",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_GenreBook_BookId1",
                table: "GenreBook",
                column: "BookId1",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_GenreBook_Books_BookId",
                table: "GenreBook",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GenreBook_Books_BookId1",
                table: "GenreBook",
                column: "BookId1",
                principalTable: "Books",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GenreBook_Genre_GenreId",
                table: "GenreBook",
                column: "GenreId",
                principalTable: "Genre",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
