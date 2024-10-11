using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CalorieTrackingApp.DAL.Migrations
{
    /// <inheritdoc />
    public partial class PortionAndFoodBeverageFK : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Portions_Beverages_BeverageId",
                table: "Portions");

            migrationBuilder.DropForeignKey(
                name: "FK_Portions_Foods_FoodId",
                table: "Portions");

            migrationBuilder.DropIndex(
                name: "IX_Portions_BeverageId",
                table: "Portions");

            migrationBuilder.DropIndex(
                name: "IX_Portions_FoodId",
                table: "Portions");

            migrationBuilder.DropColumn(
                name: "BeverageId",
                table: "Portions");

            migrationBuilder.DropColumn(
                name: "FoodId",
                table: "Portions");

            migrationBuilder.AddColumn<int>(
                name: "PortionId",
                table: "Beverages",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Foods_PortionId",
                table: "Foods",
                column: "PortionId");

            migrationBuilder.CreateIndex(
                name: "IX_Beverages_PortionId",
                table: "Beverages",
                column: "PortionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Beverages_Portions_PortionId",
                table: "Beverages",
                column: "PortionId",
                principalTable: "Portions",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Foods_Portions_PortionId",
                table: "Foods",
                column: "PortionId",
                principalTable: "Portions",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Beverages_Portions_PortionId",
                table: "Beverages");

            migrationBuilder.DropForeignKey(
                name: "FK_Foods_Portions_PortionId",
                table: "Foods");

            migrationBuilder.DropIndex(
                name: "IX_Foods_PortionId",
                table: "Foods");

            migrationBuilder.DropIndex(
                name: "IX_Beverages_PortionId",
                table: "Beverages");

            migrationBuilder.DropColumn(
                name: "PortionId",
                table: "Beverages");

            migrationBuilder.AddColumn<int>(
                name: "BeverageId",
                table: "Portions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FoodId",
                table: "Portions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Portions_BeverageId",
                table: "Portions",
                column: "BeverageId");

            migrationBuilder.CreateIndex(
                name: "IX_Portions_FoodId",
                table: "Portions",
                column: "FoodId");

            migrationBuilder.AddForeignKey(
                name: "FK_Portions_Beverages_BeverageId",
                table: "Portions",
                column: "BeverageId",
                principalTable: "Beverages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Portions_Foods_FoodId",
                table: "Portions",
                column: "FoodId",
                principalTable: "Foods",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
