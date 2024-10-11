using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CalorieTrackingApp.DAL.Migrations
{
    /// <inheritdoc />
    public partial class FoodCalorieGroupView : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
            CREATE VIEW vwUserMealFoodCalorieGroup AS
            SELECT
                umdr.UserId,
                umdr.MealName,
                SUM(umdr.FoodCalorie * umdr.Value) AS TotalFoodCalories,
                umdr.RecordDate
            FROM dbo.vwUserMealDailyFoodRecord as umdr
            GROUP BY umdr.UserId, umdr.MealName, umdr.RecordDate;
            ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DROP VIEW IF EXISTS vwUserMealFoodCalorieGroup");
        }
    }
}
