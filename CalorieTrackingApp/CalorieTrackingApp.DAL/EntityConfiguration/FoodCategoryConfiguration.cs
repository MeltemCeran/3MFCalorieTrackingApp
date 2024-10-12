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
    public class FoodCategoryConfiguration : IEntityTypeConfiguration<FoodCategory>
    {
        public void Configure(EntityTypeBuilder<FoodCategory> builder)
        {
            builder.Property(fc => fc.FoodCategoryName).HasColumnType("nvarchar(20)");

            builder.HasData(
                new FoodCategory
                {
                    Id = 1,
                    FoodCategoryName = "Kahvaltılık",
                    CreatedDate = new DateTime(2024, 10, 10, 21, 34, 51, 585, DateTimeKind.Local).AddTicks(9444)
                },
                new FoodCategory
                {
                    Id = 2,
                    FoodCategoryName = "Çorba",
                    CreatedDate = new DateTime(2024, 10, 10, 21, 34, 51, 585, DateTimeKind.Local).AddTicks(9444)
                },
                new FoodCategory
                {
                    Id = 3,
                    FoodCategoryName = "Salata",
                    CreatedDate = new DateTime(2024, 10, 10, 21, 34, 51, 585, DateTimeKind.Local).AddTicks(9444)
                },
                new FoodCategory
                {
                    Id = 4,
                    FoodCategoryName = "Ana Yemek",
                    CreatedDate = new DateTime(2024, 10, 10, 21, 34, 51, 585, DateTimeKind.Local).AddTicks(9444)
                },
                new FoodCategory
                {
                    Id = 5,
                    FoodCategoryName = "Makarna",
                    CreatedDate = new DateTime(2024, 10, 10, 21, 34, 51, 585, DateTimeKind.Local).AddTicks(9444)
                },
                new FoodCategory
                {
                    Id = 6,
                    FoodCategoryName = "Atıştırmalık",
                    CreatedDate = new DateTime(2024, 10, 10, 21, 34, 51, 585, DateTimeKind.Local).AddTicks(9444)
                },
                new FoodCategory
                {
                    Id = 7,
                    FoodCategoryName = "Tatlı",
                    CreatedDate = new DateTime(2024, 10, 10, 21, 34, 51, 585, DateTimeKind.Local).AddTicks(9444)
                });
        }
    }
}
