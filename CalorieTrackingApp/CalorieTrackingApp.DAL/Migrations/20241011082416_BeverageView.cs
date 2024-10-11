using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CalorieTrackingApp.DAL.Migrations
{
    /// <inheritdoc />
    public partial class BeverageView : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
            CREATE VIEW vwUserMealDailyBeverageRecord AS
             SELECT 
                 dur.UserId,
                 m.MealName,
                 b.BeverageCalorie,
                 p.Value,
                 dur.RecordDate 
             FROM DailyUserRecord dur
             JOIN Users u ON dur.UserId = u.Id
             JOIN Meals m ON dur.MealId = m.Id
             JOIN Beverages b ON dur.BeverageId = b.Id
             JOIN Portions p ON p.BeverageId = b.Id
            ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DROP VIEW IF EXISTS vwUserMealDailyBeverageRecord");
        }
    }
}
