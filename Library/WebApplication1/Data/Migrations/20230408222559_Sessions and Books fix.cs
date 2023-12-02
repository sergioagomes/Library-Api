using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Library.Migrations
{
    public partial class SessionsandBooksfix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BooksSessions_Libraries_LibrarieId",
                table: "BooksSessions");

            migrationBuilder.RenameColumn(
                name: "LibrarieId",
                table: "BooksSessions",
                newName: "LibrariesId");

            migrationBuilder.RenameIndex(
                name: "IX_BooksSessions_LibrarieId",
                table: "BooksSessions",
                newName: "IX_BooksSessions_LibrariesId");

            migrationBuilder.AddForeignKey(
                name: "FK_BooksSessions_Libraries_LibrariesId",
                table: "BooksSessions",
                column: "LibrariesId",
                principalTable: "Libraries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BooksSessions_Libraries_LibrariesId",
                table: "BooksSessions");

            migrationBuilder.RenameColumn(
                name: "LibrariesId",
                table: "BooksSessions",
                newName: "LibrarieId");

            migrationBuilder.RenameIndex(
                name: "IX_BooksSessions_LibrariesId",
                table: "BooksSessions",
                newName: "IX_BooksSessions_LibrarieId");

            migrationBuilder.AddForeignKey(
                name: "FK_BooksSessions_Libraries_LibrarieId",
                table: "BooksSessions",
                column: "LibrarieId",
                principalTable: "Libraries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
