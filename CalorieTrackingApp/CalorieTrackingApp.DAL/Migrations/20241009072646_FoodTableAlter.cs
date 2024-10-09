using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CalorieTrackingApp.DAL.Migrations
{
    /// <inheritdoc />
    public partial class FoodTableAlter : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FoodCalorie",
                table: "Foods");

            migrationBuilder.AddColumn<int>(
                name: "Portion",
                table: "Foods",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Portion",
                table: "Foods");

            migrationBuilder.AddColumn<string>(
                name: "FoodCalorie",
                table: "Foods",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
