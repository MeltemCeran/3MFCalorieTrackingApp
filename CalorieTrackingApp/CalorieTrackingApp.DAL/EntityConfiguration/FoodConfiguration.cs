using CalorieTrackingApp.DAL.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieTrackingApp.DAL.EntityConfiguration
{
    public class FoodConfiguration : IEntityTypeConfiguration<Food>
    {
        public void Configure(EntityTypeBuilder<Food> builder)
        {
            builder.Property(b => b.FoodName).HasColumnType("nvarchar(30)");

            builder.Property(b => b.FoodCalorie).HasColumnType("decimal(2, 2)");

            
            builder.HasData(
                new Food
                {
                    Id = 1,
                    FoodName = "Zeytin",
                    CreatedDate = new DateTime(2024, 10, 10, 21, 34, 51, 585, DateTimeKind.Local).AddTicks(9444),
                    PortionId = 2,
                    FoodCalorie = 6,
                    FoodCategoryId = 1
                },
                new Food
                {
                    Id = 2,
                    FoodName = "Beyaz Peynir",
                    CreatedDate = new DateTime(2024, 10, 10, 21, 34, 51, 585, DateTimeKind.Local).AddTicks(9444),
                    PortionId = 3,
                    FoodCalorie = 85,
                    FoodCategoryId = 1
                },
                new Food
                {
                    Id = 3,
                    FoodName = "İncir Reçeli",
                    CreatedDate = new DateTime(2024, 10, 10, 21, 34, 51, 585, DateTimeKind.Local).AddTicks(9444),
                    PortionId = 7,
                    FoodCalorie = 17,
                    FoodCategoryId = 1
                },
                new Food
                {
                    Id = 4,
                    FoodName = "Tahin Pekmez",
                    CreatedDate = new DateTime(2024, 10, 10, 21, 34, 51, 585, DateTimeKind.Local).AddTicks(9444),
                    PortionId = 7,
                    FoodCalorie = 55,
                    FoodCategoryId = 1
                },
                new Food
                {
                    Id = 5,
                    FoodName = "Mercimek Çorba",
                    CreatedDate = new DateTime(2024, 10, 10, 21, 34, 51, 585, DateTimeKind.Local).AddTicks(9444),
                    PortionId = 1,
                    FoodCalorie = 90,
                    FoodCategoryId = 2
                },
                new Food
                {
                    Id = 6,
                    FoodName = "Ezogelin Çorba",
                    CreatedDate = new DateTime(2024, 10, 10, 21, 34, 51, 585, DateTimeKind.Local).AddTicks(9444),
                    PortionId = 1,
                    FoodCalorie = 80,
                    FoodCategoryId = 2
                },
                new Food
                {
                    Id = 7,
                    FoodName = "Domates Çorba",
                    CreatedDate = new DateTime(2024, 10, 10, 21, 34, 51, 585, DateTimeKind.Local).AddTicks(9444),
                    PortionId = 1,
                    FoodCalorie = 50,
                    FoodCategoryId = 2
                },
                new Food
                {
                    Id = 8,
                    FoodName = "Mevsim Salata",
                    CreatedDate = new DateTime(2024, 10, 10, 21, 34, 51, 585, DateTimeKind.Local).AddTicks(9444),
                    PortionId = 1,
                    FoodCalorie = 35,
                    FoodCategoryId = 3
                },
                new Food
                {
                    Id = 9,
                    FoodName = "Çoban Salata",
                    CreatedDate = new DateTime(2024, 10, 10, 21, 34, 51, 585, DateTimeKind.Local).AddTicks(9444),
                    PortionId = 1,
                    FoodCalorie = 55,
                    FoodCategoryId = 3
                },
                new Food
                {
                    Id = 10,
                    FoodName = "Adana Kebap",
                    CreatedDate = new DateTime(2024, 10, 10, 21, 34, 51, 585, DateTimeKind.Local).AddTicks(9444),
                    PortionId = 1,
                    FoodCalorie = 300,
                    FoodCategoryId = 4
                },
                new Food
                {
                    Id = 11,
                    FoodName = "Zeytinyağlı Kereviz",
                    CreatedDate = new DateTime(2024, 10, 10, 21, 34, 51, 585, DateTimeKind.Local).AddTicks(9444),
                    PortionId = 1,
                    FoodCalorie = 100,
                    FoodCategoryId = 4
                },
                new Food
                {
                    Id = 12,
                    FoodName = "Kayseri Yağlaması",
                    CreatedDate = new DateTime(2024, 10, 10, 21, 34, 51, 585, DateTimeKind.Local).AddTicks(9444),
                    PortionId = 1,
                    FoodCalorie = 400,
                    FoodCategoryId = 4
                },
                new Food
                {
                    Id = 13,
                    FoodName = "Fırın Makarna",
                    CreatedDate = new DateTime(2024, 10, 10, 21, 34, 51, 585, DateTimeKind.Local).AddTicks(9444),
                    PortionId = 1,
                    FoodCalorie = 250,
                    FoodCategoryId = 5
                },
                new Food
                {
                    Id = 14,
                    FoodName = "Patates Kızartması",
                    CreatedDate = new DateTime(2024, 10, 10, 21, 34, 51, 585, DateTimeKind.Local).AddTicks(9444),
                    PortionId = 1,
                    FoodCalorie = 350,
                    FoodCategoryId = 6
                },
                new Food
                {
                    Id = 15,
                    FoodName = "Sütlaç",
                    CreatedDate = new DateTime(2024, 10, 10, 21, 34, 51, 585, DateTimeKind.Local).AddTicks(9444),
                    PortionId = 1,
                    FoodCalorie = 145,
                    FoodCategoryId = 7
                },
                new Food
                {
                    Id = 16,
                    FoodName = "Antep Fıstıklı Baklava",
                    CreatedDate = new DateTime(2024, 10, 10, 21, 34, 51, 585, DateTimeKind.Local).AddTicks(9444),
                    PortionId = 3,
                    FoodCalorie = 225,
                    FoodCategoryId = 7
                },
                new Food
                {
                    Id = 17,
                    FoodName = "Antep Fıstıklı Künefe",
                    CreatedDate = new DateTime(2024, 10, 10, 21, 34, 51, 585, DateTimeKind.Local).AddTicks(9444),
                    PortionId = 1,
                    FoodCalorie = 450,
                    FoodCategoryId = 7
                });
        }
    }
}
