using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CalorieTrackingApp.DAL.Migrations
{
    /// <inheritdoc />
    public partial class UserMealDailyFoodsRecordTableCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TotalCalories");

            migrationBuilder.DropTable(
                name: "UserMealBeverageCalorieGroups");

            migrationBuilder.DropTable(
                name: "UserMealDailyBeverageRecords");

            migrationBuilder.DropTable(
                name: "UserMealFoodCalorieGroups");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TotalCalories",
                columns: table => new
                {
                    MealName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RecordDate = table.Column<DateOnly>(type: "date", nullable: false),
                    TotalCalories = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "UserMealBeverageCalorieGroups",
                columns: table => new
                {
                    MealName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RecordDate = table.Column<DateOnly>(type: "date", nullable: false),
                    TotalBeverageCalorie = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "UserMealDailyBeverageRecords",
                columns: table => new
                {
                    BeverageCalorie = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BeverageName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MealName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RecordDate = table.Column<DateOnly>(type: "date", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Value = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "UserMealFoodCalorieGroups",
                columns: table => new
                {
                    MealName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RecordDate = table.Column<DateOnly>(type: "date", nullable: false),
                    TotalFoodCalorie = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });
        }
    }
}
