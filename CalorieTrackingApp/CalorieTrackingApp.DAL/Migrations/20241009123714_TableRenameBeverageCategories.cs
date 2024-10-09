using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CalorieTrackingApp.DAL.Migrations
{
    /// <inheritdoc />
    public partial class TableRenameBeverageCategories : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_beverageCategories",
                table: "beverageCategories");

            migrationBuilder.RenameTable(
                name: "beverageCategories",
                newName: "BeverageCategories");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BeverageCategories",
                table: "BeverageCategories",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_BeverageCategories",
                table: "BeverageCategories");

            migrationBuilder.RenameTable(
                name: "BeverageCategories",
                newName: "beverageCategories");

            migrationBuilder.AddPrimaryKey(
                name: "PK_beverageCategories",
                table: "beverageCategories",
                column: "Id");
        }
    }
}
