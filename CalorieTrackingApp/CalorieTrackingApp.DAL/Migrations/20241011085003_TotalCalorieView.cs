using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CalorieTrackingApp.DAL.Migrations
{
    /// <inheritdoc />
    public partial class TotalCalorieView : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
            CREATE VIEW vwTotalCalorieView AS
            SELECT 
                UserId, 
                MealName, 
                TotalFoodCalories AS TotalCalories, 
                RecordDate 
            FROM dbo.vwUserMealFoodCalorieGroup
            UNION ALL
            SELECT * FROM dbo.vwUserMealBeverageCalorieGroup
            ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DROP VIEW IF EXISTS vwTotalCalorieView");
        }
    }
}
