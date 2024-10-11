using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CalorieTrackingApp.DAL.Migrations
{
    /// <inheritdoc />
    public partial class BeverageCalorieGroupView : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
            CREATE VIEW vwUserMealBeverageCalorieGroup AS
            SELECT
                umdr.UserId,
                umdr.MealName,
                SUM(umdr.BeverageCalorie * umdr.Value) AS TotalBeverageCalories,
                umdr.RecordDate
            FROM dbo.vwUserMealDailyBeverageRecord as umdr
            GROUP BY umdr.UserId, umdr.MealName, umdr.RecordDate;
            ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DROP VIEW IF EXISTS vwUserMealBeverageCalorieGroup");
        }
    }
}
