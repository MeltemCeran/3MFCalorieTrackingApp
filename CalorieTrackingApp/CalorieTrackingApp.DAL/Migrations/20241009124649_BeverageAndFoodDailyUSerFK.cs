using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CalorieTrackingApp.DAL.Migrations
{
    /// <inheritdoc />
    public partial class BeverageAndFoodDailyUSerFK : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BeveragesId",
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

            migrationBuilder.CreateIndex(
                name: "IX_DailyUserRecord_BeveragesId",
                table: "DailyUserRecord",
                column: "BeveragesId");

            migrationBuilder.CreateIndex(
                name: "IX_DailyUserRecord_FoodsId",
                table: "DailyUserRecord",
                column: "FoodsId");

            migrationBuilder.AddForeignKey(
                name: "FK_DailyUserRecord_Beverages_BeveragesId",
                table: "DailyUserRecord",
                column: "BeveragesId",
                principalTable: "Beverages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DailyUserRecord_Foods_FoodsId",
                table: "DailyUserRecord",
                column: "FoodsId",
                principalTable: "Foods",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DailyUserRecord_Beverages_BeveragesId",
                table: "DailyUserRecord");

            migrationBuilder.DropForeignKey(
                name: "FK_DailyUserRecord_Foods_FoodsId",
                table: "DailyUserRecord");

            migrationBuilder.DropIndex(
                name: "IX_DailyUserRecord_BeveragesId",
                table: "DailyUserRecord");

            migrationBuilder.DropIndex(
                name: "IX_DailyUserRecord_FoodsId",
                table: "DailyUserRecord");

            migrationBuilder.DropColumn(
                name: "BeveragesId",
                table: "DailyUserRecord");

            migrationBuilder.DropColumn(
                name: "FoodsId",
                table: "DailyUserRecord");
        }
    }
}
