using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryManagementSystem.Migrations
{
    public partial class BookTransactionTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserRoles_Users_UserEntityUserId",
                table: "UserRoles");

            migrationBuilder.DropTable(
                name: "BorrowBook");

            migrationBuilder.DropIndex(
                name: "IX_UserRoles_UserEntityUserId",
                table: "UserRoles");

            migrationBuilder.DropColumn(
                name: "UserEntityUserId",
                table: "UserRoles");

            migrationBuilder.CreateTable(
                name: "BorrowBooks",
                columns: table => new
                {
                    BorrowedBookId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BorrowedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DueDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BorrowedPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    BookId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BorrowBooks", x => x.BorrowedBookId);
                    table.ForeignKey(
                        name: "FK_Borrow_Book",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "BookId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BorrowBook_User",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BorrowBooks_BookId",
                table: "BorrowBooks",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_BorrowBooks_UserId",
                table: "BorrowBooks",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BorrowBooks");

            migrationBuilder.AddColumn<int>(
                name: "UserEntityUserId",
                table: "UserRoles",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "BorrowBook",
                columns: table => new
                {
                    BarrowedItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    BarrowedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BarrowedPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BooksEntityBookId = table.Column<int>(type: "int", nullable: true),
                    DueDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    UserEntityUserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BorrowBook", x => x.BarrowedItemId);
                    table.ForeignKey(
                        name: "FK_BorrowBook_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "BookId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BorrowBook_Books_BooksEntityBookId",
                        column: x => x.BooksEntityBookId,
                        principalTable: "Books",
                        principalColumn: "BookId");
                    table.ForeignKey(
                        name: "FK_BorrowBook_Users_UserEntityUserId",
                        column: x => x.UserEntityUserId,
                        principalTable: "Users",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_BorrowBook_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_UserEntityUserId",
                table: "UserRoles",
                column: "UserEntityUserId");

            migrationBuilder.CreateIndex(
                name: "IX_BorrowBook_BookId",
                table: "BorrowBook",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_BorrowBook_BooksEntityBookId",
                table: "BorrowBook",
                column: "BooksEntityBookId");

            migrationBuilder.CreateIndex(
                name: "IX_BorrowBook_UserEntityUserId",
                table: "BorrowBook",
                column: "UserEntityUserId");

            migrationBuilder.CreateIndex(
                name: "IX_BorrowBook_UserId",
                table: "BorrowBook",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserRoles_Users_UserEntityUserId",
                table: "UserRoles",
                column: "UserEntityUserId",
                principalTable: "Users",
                principalColumn: "UserId");
        }
    }
}
