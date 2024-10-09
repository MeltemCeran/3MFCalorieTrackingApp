using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CalorieTrackingApp.DAL.Migrations
{
    /// <inheritdoc />
    public partial class FixedFKAraMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DailyUserRecord_Beverages_BeveragesId",
                table: "DailyUserRecord");

            migrationBuilder.DropForeignKey(
                name: "FK_DailyUserRecord_FoodCategories_FoodCategoriesId",
                table: "DailyUserRecord");

            migrationBuilder.DropForeignKey(
                name: "FK_DailyUserRecord_Foods_FoodsId",
                table: "DailyUserRecord");

            migrationBuilder.DropForeignKey(
                name: "FK_DailyUserRecord_beverageCategories_BeverageCetegoriesId",
                table: "DailyUserRecord");

            migrationBuilder.DropIndex(
                name: "IX_DailyUserRecord_BeverageCetegoriesId",
                table: "DailyUserRecord");

            migrationBuilder.DropIndex(
                name: "IX_DailyUserRecord_BeveragesId",
                table: "DailyUserRecord");

            migrationBuilder.DropIndex(
                name: "IX_DailyUserRecord_FoodCategoriesId",
                table: "DailyUserRecord");

            migrationBuilder.DropIndex(
                name: "IX_DailyUserRecord_FoodsId",
                table: "DailyUserRecord");

            migrationBuilder.DropColumn(
                name: "BeverageCetegoriesId",
                table: "DailyUserRecord");

            migrationBuilder.DropColumn(
                name: "BeveragesId",
                table: "DailyUserRecord");

            migrationBuilder.DropColumn(
                name: "FoodCategoriesId",
                table: "DailyUserRecord");

            migrationBuilder.DropColumn(
                name: "FoodsId",
                table: "DailyUserRecord");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FoodCategoryId",
                table: "Foods",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BeverageCetegoriesId",
                table: "DailyUserRecord",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BeveragesId",
                table: "DailyUserRecord",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FoodCategoriesId",
                table: "DailyUserRecord",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FoodsId",
                table: "DailyUserRecord",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BeverageCategoryId",
                table: "Beverages",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Foods_FoodCategoryId",
                table: "Foods",
                column: "FoodCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_DailyUserRecord_BeverageCetegoriesId",
                table: "DailyUserRecord",
                column: "BeverageCetegoriesId");

            migrationBuilder.CreateIndex(
                name: "IX_DailyUserRecord_BeveragesId",
                table: "DailyUserRecord",
                column: "BeveragesId");

            migrationBuilder.CreateIndex(
                name: "IX_DailyUserRecord_FoodCategoriesId",
                table: "DailyUserRecord",
                column: "FoodCategoriesId");

            migrationBuilder.CreateIndex(
                name: "IX_DailyUserRecord_FoodsId",
                table: "DailyUserRecord",
                column: "FoodsId");

            migrationBuilder.CreateIndex(
                name: "IX_Beverages_BeverageCategoryId",
                table: "Beverages",
                column: "BeverageCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Beverages_beverageCategories_BeverageCategoryId",
                table: "Beverages",
                column: "BeverageCategoryId",
                principalTable: "beverageCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DailyUserRecord_Beverages_BeveragesId",
                table: "DailyUserRecord",
                column: "BeveragesId",
                principalTable: "Beverages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DailyUserRecord_FoodCategories_FoodCategoriesId",
                table: "DailyUserRecord",
                column: "FoodCategoriesId",
                principalTable: "FoodCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DailyUserRecord_Foods_FoodsId",
                table: "DailyUserRecord",
                column: "FoodsId",
                principalTable: "Foods",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DailyUserRecord_beverageCategories_BeverageCetegoriesId",
                table: "DailyUserRecord",
                column: "BeverageCetegoriesId",
                principalTable: "beverageCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Foods_FoodCategories_FoodCategoryId",
                table: "Foods",
                column: "FoodCategoryId",
                principalTable: "FoodCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
