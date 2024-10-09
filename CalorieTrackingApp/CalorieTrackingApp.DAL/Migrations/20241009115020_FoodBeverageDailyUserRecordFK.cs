using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CalorieTrackingApp.DAL.Migrations
{
    /// <inheritdoc />
    public partial class FoodBeverageDailyUserRecordFK : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FoodCategories_FoodCategories_FoodCategoryId",
                table: "FoodCategories");

            migrationBuilder.DropIndex(
                name: "IX_FoodCategories_FoodCategoryId",
                table: "FoodCategories");

            migrationBuilder.DropColumn(
                name: "FoodCategoryId",
                table: "FoodCategories");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FoodCategoryId",
                table: "FoodCategories",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_FoodCategories_FoodCategoryId",
                table: "FoodCategories",
                column: "FoodCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_FoodCategories_FoodCategories_FoodCategoryId",
                table: "FoodCategories",
                column: "FoodCategoryId",
                principalTable: "FoodCategories",
                principalColumn: "Id");
        }
    }
}
