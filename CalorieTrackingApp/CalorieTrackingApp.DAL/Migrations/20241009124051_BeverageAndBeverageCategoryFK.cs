using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CalorieTrackingApp.DAL.Migrations
{
    /// <inheritdoc />
    public partial class BeverageAndBeverageCategoryFK : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BeverageCategoryId",
                table: "Beverages",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Beverages_BeverageCategoryId",
                table: "Beverages",
                column: "BeverageCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Beverages_BeverageCategories_BeverageCategoryId",
                table: "Beverages",
                column: "BeverageCategoryId",
                principalTable: "BeverageCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Beverages_BeverageCategories_BeverageCategoryId",
                table: "Beverages");

            migrationBuilder.DropIndex(
                name: "IX_Beverages_BeverageCategoryId",
                table: "Beverages");

            migrationBuilder.DropColumn(
                name: "BeverageCategoryId",
                table: "Beverages");
        }
    }
}
