using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryManagementSystem.Migrations
{
    public partial class NewBarrowBook : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BarrowBook_Books_BookId",
                table: "BarrowBook");

            migrationBuilder.DropForeignKey(
                name: "FK_BarrowBook_Users_UserId",
                table: "BarrowBook");

            migrationBuilder.AlterColumn<decimal>(
                name: "BarrowedPrice",
                table: "BarrowBook",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldDefaultValue: 0m);

            migrationBuilder.AlterColumn<DateTime>(
                name: "BarrowedDate",
                table: "BarrowBook",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValueSql: "GETDATE()");

            migrationBuilder.AddForeignKey(
                name: "FK_BarrowBook_Books_BookId",
                table: "BarrowBook",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "BookId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BarrowBook_Users_UserId",
                table: "BarrowBook",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BarrowBook_Books_BookId",
                table: "BarrowBook");

            migrationBuilder.DropForeignKey(
                name: "FK_BarrowBook_Users_UserId",
                table: "BarrowBook");

            migrationBuilder.AlterColumn<decimal>(
                name: "BarrowedPrice",
                table: "BarrowBook",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "BarrowedDate",
                table: "BarrowBook",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "GETDATE()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddForeignKey(
                name: "FK_BarrowBook_Books_BookId",
                table: "BarrowBook",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "BookId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BarrowBook_Users_UserId",
                table: "BarrowBook",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
