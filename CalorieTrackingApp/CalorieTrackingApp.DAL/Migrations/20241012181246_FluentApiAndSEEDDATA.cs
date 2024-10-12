using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CalorieTrackingApp.DAL.Migrations
{
    /// <inheritdoc />
    public partial class FluentApiAndSEEDDATA : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BeverageName",
                table: "UserMealDailyBeverageRecords",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<decimal>(
                name: "Value",
                table: "Portions",
                type: "decimal(7,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<string>(
                name: "ProductType",
                table: "Portions",
                type: "nvarchar(15)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "PortionType",
                table: "Portions",
                type: "nvarchar(15)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "MealName",
                table: "Meals",
                type: "nvarchar(15)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<decimal>(
                name: "FoodCalorie",
                table: "Foods",
                type: "decimal(7,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<string>(
                name: "FoodCategoryName",
                table: "FoodCategories",
                type: "nvarchar(20)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<decimal>(
                name: "BeverageCalorie",
                table: "Beverages",
                type: "decimal(7,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<string>(
                name: "BeverageCategoryName",
                table: "BeverageCategories",
                type: "nvarchar(20)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 1,
                column: "Surname",
                value: "Admin_Surname");

            migrationBuilder.InsertData(
                table: "BeverageCategories",
                columns: new[] { "Id", "BeverageCategoryName", "CreatedDate", "DataStatus", "DeletedDate", "ModifiedDate" },
                values: new object[] { 3, "Su", new DateTime(2024, 10, 10, 21, 34, 51, 585, DateTimeKind.Local).AddTicks(9444), 0, null, null });

            migrationBuilder.UpdateData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "FoodCategoryName",
                value: "Kahvaltılık");

            migrationBuilder.UpdateData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "FoodCategoryName",
                value: "Çorba");

            migrationBuilder.UpdateData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "FoodCategoryName",
                value: "Salata");

            migrationBuilder.UpdateData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "FoodCategoryName",
                value: "Ana Yemek");

            migrationBuilder.UpdateData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "FoodCategoryName",
                value: "Makarna");

            migrationBuilder.UpdateData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "FoodCategoryName",
                value: "Atıştırmalık");

            migrationBuilder.InsertData(
                table: "FoodCategories",
                columns: new[] { "Id", "CreatedDate", "DataStatus", "DeletedDate", "FoodCategoryName", "ModifiedDate" },
                values: new object[] { 7, new DateTime(2024, 10, 10, 21, 34, 51, 585, DateTimeKind.Local).AddTicks(9444), 0, null, "Tatlı", null });

            migrationBuilder.InsertData(
                table: "Portions",
                columns: new[] { "Id", "CreatedDate", "DataStatus", "DeletedDate", "ModifiedDate", "PortionType", "ProductType", "Value" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 10, 10, 21, 34, 51, 585, DateTimeKind.Local).AddTicks(9444), 0, null, null, "Porsiyon(gr)", "Yiyecek", 125m },
                    { 2, new DateTime(2024, 10, 10, 21, 34, 51, 585, DateTimeKind.Local).AddTicks(9444), 0, null, null, "Adet(tane)", "Yiyecek", 1m },
                    { 3, new DateTime(2024, 10, 10, 21, 34, 51, 585, DateTimeKind.Local).AddTicks(9444), 0, null, null, "Dilim(tane)", "Yiyecek", 1m },
                    { 4, new DateTime(2024, 10, 10, 21, 34, 51, 585, DateTimeKind.Local).AddTicks(9444), 0, null, null, "Fincan(ml)", "İçecek", 100m },
                    { 5, new DateTime(2024, 10, 10, 21, 34, 51, 585, DateTimeKind.Local).AddTicks(9444), 0, null, null, "Kupa Bardak(ml)", "İçecek", 200m },
                    { 6, new DateTime(2024, 10, 10, 21, 34, 51, 585, DateTimeKind.Local).AddTicks(9444), 0, null, null, "Kutu(ml)", "İçecek", 330m },
                    { 7, new DateTime(2024, 10, 10, 21, 34, 51, 585, DateTimeKind.Local).AddTicks(9444), 0, null, null, "Çay Kaşığı(gr)", "Yiyecek", 5m }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedDate", "DataStatus", "DeletedDate", "Email", "ModifiedDate", "Name", "Password", "Surname", "UserAgeGap", "UserGoal", "UserName" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 10, 10, 21, 34, 51, 585, DateTimeKind.Local).AddTicks(9444), 0, null, "kgkalyoncu@mail.com", null, "Kazım Göksel", "kgk*user", "Kalyoncu", 4, 2, "kgkalyoncu@mail.com" },
                    { 2, new DateTime(2024, 10, 10, 21, 34, 51, 585, DateTimeKind.Local).AddTicks(9444), 0, null, "alpceyhan@mail.com", null, "Alp", "alp*user", "Ceyhan", 4, 2, "alpceyhan@mail.com" },
                    { 3, new DateTime(2024, 10, 10, 21, 34, 51, 585, DateTimeKind.Local).AddTicks(9444), 0, null, "alkinbayrak@mail.com", null, "Yahya Alkın", "ayb*user", "Bayrak", 3, 3, "alkinbayrak@mail.com" },
                    { 4, new DateTime(2024, 10, 10, 21, 34, 51, 585, DateTimeKind.Local).AddTicks(9444), 0, null, "minelk@mail.com", null, "Minel", "minelk*user", "Karakökçek", 2, 3, "minelk@mail.com" },
                    { 5, new DateTime(2024, 10, 10, 21, 34, 51, 585, DateTimeKind.Local).AddTicks(9444), 0, null, "efnan@mail.com", null, "Efnan", "efnan*user", "Genç", 1, 3, "efnan@mail.com" }
                });

            migrationBuilder.InsertData(
                table: "Beverages",
                columns: new[] { "Id", "BeverageCalorie", "BeverageCategoryId", "BeverageName", "CreatedDate", "DataStatus", "DeletedDate", "ModifiedDate", "PortionId" },
                values: new object[,]
                {
                    { 1, 0m, 3, "Su", new DateTime(2024, 10, 10, 21, 34, 51, 585, DateTimeKind.Local).AddTicks(9444), 0, null, null, 5 },
                    { 2, 2m, 1, "Sade Türk Kahvesi", new DateTime(2024, 10, 10, 21, 34, 51, 585, DateTimeKind.Local).AddTicks(9444), 0, null, null, 4 },
                    { 3, 15m, 1, "Orta Türk Kahvesi", new DateTime(2024, 10, 10, 21, 34, 51, 585, DateTimeKind.Local).AddTicks(9444), 0, null, null, 4 },
                    { 4, 25m, 1, "Şekerli Türk Kahvesi", new DateTime(2024, 10, 10, 21, 34, 51, 585, DateTimeKind.Local).AddTicks(9444), 0, null, null, 4 },
                    { 5, 149m, 2, "Kola", new DateTime(2024, 10, 10, 21, 34, 51, 585, DateTimeKind.Local).AddTicks(9444), 0, null, null, 6 },
                    { 6, 1m, 2, "Light veya Zero Kola", new DateTime(2024, 10, 10, 21, 34, 51, 585, DateTimeKind.Local).AddTicks(9444), 0, null, null, 6 },
                    { 7, 60m, 2, "Soğuk Çay", new DateTime(2024, 10, 10, 21, 34, 51, 585, DateTimeKind.Local).AddTicks(9444), 0, null, null, 6 },
                    { 8, 10m, 2, "Light veya Zero Soğuk Çay", new DateTime(2024, 10, 10, 21, 34, 51, 585, DateTimeKind.Local).AddTicks(9444), 0, null, null, 6 },
                    { 9, 40m, 2, "Şalgam(Acılı)", new DateTime(2024, 10, 10, 21, 34, 51, 585, DateTimeKind.Local).AddTicks(9444), 0, null, null, 5 }
                });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "Id", "CreatedDate", "DataStatus", "DeletedDate", "FoodCalorie", "FoodCategoryId", "FoodName", "ModifiedDate", "PortionId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 10, 10, 21, 34, 51, 585, DateTimeKind.Local).AddTicks(9444), 0, null, 6m, 1, "Zeytin", null, 2 },
                    { 2, new DateTime(2024, 10, 10, 21, 34, 51, 585, DateTimeKind.Local).AddTicks(9444), 0, null, 85m, 1, "Beyaz Peynir", null, 3 },
                    { 3, new DateTime(2024, 10, 10, 21, 34, 51, 585, DateTimeKind.Local).AddTicks(9444), 0, null, 17m, 1, "İncir Reçeli", null, 7 },
                    { 4, new DateTime(2024, 10, 10, 21, 34, 51, 585, DateTimeKind.Local).AddTicks(9444), 0, null, 55m, 1, "Tahin Pekmez", null, 7 },
                    { 5, new DateTime(2024, 10, 10, 21, 34, 51, 585, DateTimeKind.Local).AddTicks(9444), 0, null, 90m, 2, "Mercimek Çorba", null, 1 },
                    { 6, new DateTime(2024, 10, 10, 21, 34, 51, 585, DateTimeKind.Local).AddTicks(9444), 0, null, 80m, 2, "Ezogelin Çorba", null, 1 },
                    { 7, new DateTime(2024, 10, 10, 21, 34, 51, 585, DateTimeKind.Local).AddTicks(9444), 0, null, 50m, 2, "Domates Çorba", null, 1 },
                    { 8, new DateTime(2024, 10, 10, 21, 34, 51, 585, DateTimeKind.Local).AddTicks(9444), 0, null, 35m, 3, "Mevsim Salata", null, 1 },
                    { 9, new DateTime(2024, 10, 10, 21, 34, 51, 585, DateTimeKind.Local).AddTicks(9444), 0, null, 55m, 3, "Çoban Salata", null, 1 },
                    { 10, new DateTime(2024, 10, 10, 21, 34, 51, 585, DateTimeKind.Local).AddTicks(9444), 0, null, 300m, 4, "Adana Kebap", null, 1 },
                    { 11, new DateTime(2024, 10, 10, 21, 34, 51, 585, DateTimeKind.Local).AddTicks(9444), 0, null, 100m, 4, "Zeytinyağlı Kereviz", null, 1 },
                    { 12, new DateTime(2024, 10, 10, 21, 34, 51, 585, DateTimeKind.Local).AddTicks(9444), 0, null, 400m, 4, "Kayseri Yağlaması", null, 1 },
                    { 13, new DateTime(2024, 10, 10, 21, 34, 51, 585, DateTimeKind.Local).AddTicks(9444), 0, null, 250m, 5, "Fırın Makarna", null, 1 },
                    { 14, new DateTime(2024, 10, 10, 21, 34, 51, 585, DateTimeKind.Local).AddTicks(9444), 0, null, 350m, 6, "Patates Kızartması", null, 1 },
                    { 15, new DateTime(2024, 10, 10, 21, 34, 51, 585, DateTimeKind.Local).AddTicks(9444), 0, null, 145m, 7, "Sütlaç", null, 1 },
                    { 16, new DateTime(2024, 10, 10, 21, 34, 51, 585, DateTimeKind.Local).AddTicks(9444), 0, null, 225m, 7, "Antep Fıstıklı Baklava", null, 3 },
                    { 17, new DateTime(2024, 10, 10, 21, 34, 51, 585, DateTimeKind.Local).AddTicks(9444), 0, null, 450m, 7, "Antep Fıstıklı Künefe", null, 1 }
                });

            migrationBuilder.InsertData(
                table: "DailyUserRecord",
                columns: new[] { "Id", "BeverageId", "CreatedDate", "DataStatus", "DeletedDate", "FoodId", "MealId", "ModifiedDate", "PortionId", "RecordDate", "UserId" },
                values: new object[,]
                {
                    { 1, 2, new DateTime(2024, 10, 10, 21, 34, 51, 585, DateTimeKind.Local).AddTicks(9444), 0, null, 16, 1, null, 3, new DateOnly(2024, 10, 10), 1 },
                    { 2, 9, new DateTime(2024, 10, 10, 21, 34, 51, 585, DateTimeKind.Local).AddTicks(9444), 0, null, 10, 2, null, 1, new DateOnly(2024, 10, 10), 2 },
                    { 3, 7, new DateTime(2024, 10, 10, 21, 34, 51, 585, DateTimeKind.Local).AddTicks(9444), 0, null, 12, 4, null, 1, new DateOnly(2024, 10, 10), 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Beverages",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Beverages",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Beverages",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Beverages",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Beverages",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Beverages",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "DailyUserRecord",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DailyUserRecord",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DailyUserRecord",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "BeverageCategories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Beverages",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Beverages",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Beverages",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Portions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Portions",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Portions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Portions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Portions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Portions",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Portions",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DropColumn(
                name: "BeverageName",
                table: "UserMealDailyBeverageRecords");

            migrationBuilder.AlterColumn<decimal>(
                name: "Value",
                table: "Portions",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(7,2)");

            migrationBuilder.AlterColumn<string>(
                name: "ProductType",
                table: "Portions",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)");

            migrationBuilder.AlterColumn<string>(
                name: "PortionType",
                table: "Portions",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)");

            migrationBuilder.AlterColumn<string>(
                name: "MealName",
                table: "Meals",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)");

            migrationBuilder.AlterColumn<decimal>(
                name: "FoodCalorie",
                table: "Foods",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(7,2)");

            migrationBuilder.AlterColumn<string>(
                name: "FoodCategoryName",
                table: "FoodCategories",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)");

            migrationBuilder.AlterColumn<decimal>(
                name: "BeverageCalorie",
                table: "Beverages",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(7,2)");

            migrationBuilder.AlterColumn<string>(
                name: "BeverageCategoryName",
                table: "BeverageCategories",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)");

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 1,
                column: "Surname",
                value: "admin@example.com");

            migrationBuilder.UpdateData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "FoodCategoryName",
                value: "Çorba");

            migrationBuilder.UpdateData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "FoodCategoryName",
                value: "Salata");

            migrationBuilder.UpdateData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "FoodCategoryName",
                value: "Ana Yemek");

            migrationBuilder.UpdateData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "FoodCategoryName",
                value: "Makarna");

            migrationBuilder.UpdateData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "FoodCategoryName",
                value: "Atıştırmalık");

            migrationBuilder.UpdateData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "FoodCategoryName",
                value: "Tatlı");
        }
    }
}
