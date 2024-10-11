using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CalorieTrackingApp.DAL.Migrations
{
    /// <inheritdoc />
    public partial class PortionAndDailyUserRecordFK : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PortionId",
                table: "DailyUserRecord",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_DailyUserRecord_PortionId",
                table: "DailyUserRecord",
                column: "PortionId");

            migrationBuilder.AddForeignKey(
                name: "FK_DailyUserRecord_Portions_PortionId",
                table: "DailyUserRecord",
                column: "PortionId",
                principalTable: "Portions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DailyUserRecord_Portions_PortionId",
                table: "DailyUserRecord");

            migrationBuilder.DropIndex(
                name: "IX_DailyUserRecord_PortionId",
                table: "DailyUserRecord");

            migrationBuilder.DropColumn(
                name: "PortionId",
                table: "DailyUserRecord");
        }
    }
}
