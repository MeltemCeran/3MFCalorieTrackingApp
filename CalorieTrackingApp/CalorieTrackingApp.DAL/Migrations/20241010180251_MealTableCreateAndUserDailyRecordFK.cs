using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CalorieTrackingApp.DAL.Migrations
{
    /// <inheritdoc />
    public partial class MealTableCreateAndUserDailyRecordFK : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DailyUserRecord_Beverages_BeveragesId",
                table: "DailyUserRecord");

            migrationBuilder.DropForeignKey(
                name: "FK_DailyUserRecord_Foods_FoodsId",
                table: "DailyUserRecord");

            migrationBuilder.DropForeignKey(
                name: "FK_DailyUserRecord_Users_UsersId",
                table: "DailyUserRecord");

            migrationBuilder.RenameColumn(
                name: "UsersId",
                table: "DailyUserRecord",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "Meals",
                table: "DailyUserRecord",
                newName: "MealId");

            migrationBuilder.RenameColumn(
                name: "FoodsId",
                table: "DailyUserRecord",
                newName: "FoodId");

            migrationBuilder.RenameColumn(
                name: "BeveragesId",
                table: "DailyUserRecord",
                newName: "BeverageId");

            migrationBuilder.RenameIndex(
                name: "IX_DailyUserRecord_UsersId",
                table: "DailyUserRecord",
                newName: "IX_DailyUserRecord_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_DailyUserRecord_FoodsId",
                table: "DailyUserRecord",
                newName: "IX_DailyUserRecord_FoodId");

            migrationBuilder.RenameIndex(
                name: "IX_DailyUserRecord_BeveragesId",
                table: "DailyUserRecord",
                newName: "IX_DailyUserRecord_BeverageId");

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "Users",
                type: "varchar(30)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Surname",
                table: "Users",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Users",
                type: "varchar(20)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Users",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Users",
                type: "varchar(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FoodName",
                table: "Foods",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FoodCategoryName",
                table: "FoodCategories",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<DateOnly>(
                name: "RecordDate",
                table: "DailyUserRecord",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));

            migrationBuilder.AlterColumn<string>(
                name: "BeverageName",
                table: "Beverages",
                type: "nvarchar(30)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "BeverageCategoryName",
                table: "BeverageCategories",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Surname",
                table: "Admins",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Admins",
                type: "varchar(20)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Admins",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "AdminName",
                table: "Admins",
                type: "varchar(30)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "Meals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MealName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataStatus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meals", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 10, 21, 2, 50, 878, DateTimeKind.Local).AddTicks(7822));

            migrationBuilder.CreateIndex(
                name: "IX_DailyUserRecord_MealId",
                table: "DailyUserRecord",
                column: "MealId");

            migrationBuilder.AddForeignKey(
                name: "FK_DailyUserRecord_Beverages_BeverageId",
                table: "DailyUserRecord",
                column: "BeverageId",
                principalTable: "Beverages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DailyUserRecord_Foods_FoodId",
                table: "DailyUserRecord",
                column: "FoodId",
                principalTable: "Foods",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DailyUserRecord_Meals_MealId",
                table: "DailyUserRecord",
                column: "MealId",
                principalTable: "Meals",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DailyUserRecord_Users_UserId",
                table: "DailyUserRecord",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DailyUserRecord_Beverages_BeverageId",
                table: "DailyUserRecord");

            migrationBuilder.DropForeignKey(
                name: "FK_DailyUserRecord_Foods_FoodId",
                table: "DailyUserRecord");

            migrationBuilder.DropForeignKey(
                name: "FK_DailyUserRecord_Meals_MealId",
                table: "DailyUserRecord");

            migrationBuilder.DropForeignKey(
                name: "FK_DailyUserRecord_Users_UserId",
                table: "DailyUserRecord");

            migrationBuilder.DropTable(
                name: "Meals");

            migrationBuilder.DropIndex(
                name: "IX_DailyUserRecord_MealId",
                table: "DailyUserRecord");

            migrationBuilder.DropColumn(
                name: "RecordDate",
                table: "DailyUserRecord");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "DailyUserRecord",
                newName: "UsersId");

            migrationBuilder.RenameColumn(
                name: "MealId",
                table: "DailyUserRecord",
                newName: "Meals");

            migrationBuilder.RenameColumn(
                name: "FoodId",
                table: "DailyUserRecord",
                newName: "FoodsId");

            migrationBuilder.RenameColumn(
                name: "BeverageId",
                table: "DailyUserRecord",
                newName: "BeveragesId");

            migrationBuilder.RenameIndex(
                name: "IX_DailyUserRecord_UserId",
                table: "DailyUserRecord",
                newName: "IX_DailyUserRecord_UsersId");

            migrationBuilder.RenameIndex(
                name: "IX_DailyUserRecord_FoodId",
                table: "DailyUserRecord",
                newName: "IX_DailyUserRecord_FoodsId");

            migrationBuilder.RenameIndex(
                name: "IX_DailyUserRecord_BeverageId",
                table: "DailyUserRecord",
                newName: "IX_DailyUserRecord_BeveragesId");

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(30)");

            migrationBuilder.AlterColumn<string>(
                name: "Surname",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(20)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(50)");

            migrationBuilder.AlterColumn<string>(
                name: "FoodName",
                table: "Foods",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "FoodCategoryName",
                table: "FoodCategories",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "BeverageName",
                table: "Beverages",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)");

            migrationBuilder.AlterColumn<string>(
                name: "BeverageCategoryName",
                table: "BeverageCategories",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "Surname",
                table: "Admins",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Admins",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(20)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Admins",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "AdminName",
                table: "Admins",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(30)");

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

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

            migrationBuilder.AddForeignKey(
                name: "FK_DailyUserRecord_Users_UsersId",
                table: "DailyUserRecord",
                column: "UsersId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
