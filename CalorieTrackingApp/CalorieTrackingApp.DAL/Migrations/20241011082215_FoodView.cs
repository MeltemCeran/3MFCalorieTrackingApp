using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CalorieTrackingApp.DAL.Migrations
{
    /// <inheritdoc />
    public partial class FoodView : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
            CREATE VIEW vwUserMealDailyFoodRecord AS
             SELECT 
                 dur.UserId,
                 m.MealName,
                 f.FoodCalorie,
                 p.Value,
                 dur.RecordDate 
             FROM DailyUserRecord dur
             JOIN Users u ON dur.UserId = u.Id
             JOIN Meals m ON dur.MealId = m.Id
             JOIN Foods f ON dur.FoodId = f.Id
             JOIN Portions p ON p.FoodId = f.Id
            ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DROP VIEW IF EXISTS vwUserMealDailyFoodRecord");
        }
    }
}
