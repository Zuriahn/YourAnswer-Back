using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class categorytablefixname : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Question_categoryDMs_CategoryId",
                table: "Question");

            migrationBuilder.DropPrimaryKey(
                name: "PK_categoryDMs",
                table: "categoryDMs");

            migrationBuilder.RenameTable(
                name: "categoryDMs",
                newName: "Category");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Category",
                table: "Category",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Question_Category_CategoryId",
                table: "Question",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Question_Category_CategoryId",
                table: "Question");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Category",
                table: "Category");

            migrationBuilder.RenameTable(
                name: "Category",
                newName: "categoryDMs");

            migrationBuilder.AddPrimaryKey(
                name: "PK_categoryDMs",
                table: "categoryDMs",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Question_categoryDMs_CategoryId",
                table: "Question",
                column: "CategoryId",
                principalTable: "categoryDMs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
