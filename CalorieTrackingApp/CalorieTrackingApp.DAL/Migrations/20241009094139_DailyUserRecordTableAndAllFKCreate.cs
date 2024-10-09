using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CalorieTrackingApp.DAL.Migrations
{
    /// <inheritdoc />
    public partial class DailyUserRecordTableAndAllFKCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FoodCategoryId",
                table: "FoodCategories",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "DailyUserRecord",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsersId = table.Column<int>(type: "int", nullable: false),
                    Meals = table.Column<int>(type: "int", nullable: false),
                    FoodCategoriesId = table.Column<int>(type: "int", nullable: false),
                    FoodsId = table.Column<int>(type: "int", nullable: false),
                    FoodPortions = table.Column<int>(type: "int", nullable: false),
                    BeverageCetegoriesId = table.Column<int>(type: "int", nullable: false),
                    BeveragesId = table.Column<int>(type: "int", nullable: false),
                    BeveragesPortions = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataStatus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DailyUserRecord", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DailyUserRecord_Beverages_BeveragesId",
                        column: x => x.BeveragesId,
                        principalTable: "Beverages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DailyUserRecord_FoodCategories_FoodCategoriesId",
                        column: x => x.FoodCategoriesId,
                        principalTable: "FoodCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DailyUserRecord_Foods_FoodsId",
                        column: x => x.FoodsId,
                        principalTable: "Foods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DailyUserRecord_Users_UsersId",
                        column: x => x.UsersId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DailyUserRecord_beverageCategories_BeverageCetegoriesId",
                        column: x => x.BeverageCetegoriesId,
                        principalTable: "beverageCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FoodCategories_FoodCategoryId",
                table: "FoodCategories",
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
                name: "IX_DailyUserRecord_UsersId",
                table: "DailyUserRecord",
                column: "UsersId");

            migrationBuilder.AddForeignKey(
                name: "FK_FoodCategories_FoodCategories_FoodCategoryId",
                table: "FoodCategories",
                column: "FoodCategoryId",
                principalTable: "FoodCategories",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FoodCategories_FoodCategories_FoodCategoryId",
                table: "FoodCategories");

            migrationBuilder.DropTable(
                name: "DailyUserRecord");

            migrationBuilder.DropIndex(
                name: "IX_FoodCategories_FoodCategoryId",
                table: "FoodCategories");

            migrationBuilder.DropColumn(
                name: "FoodCategoryId",
                table: "FoodCategories");
        }
    }
}
