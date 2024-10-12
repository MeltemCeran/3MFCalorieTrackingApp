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
    public class BeverageCategoryConfiguration : IEntityTypeConfiguration<BeverageCategory>
    {
        public void Configure(EntityTypeBuilder<BeverageCategory> builder)
        {
            builder.Property(bc => bc.BeverageCategoryName).HasColumnType("nvarchar(20)");

            builder.HasData(
                new BeverageCategory
                {
                    Id = 1,
                    BeverageCategoryName = "Sıcak İçecek",
                    CreatedDate = new DateTime(2024, 10, 10, 21, 34, 51, 585, DateTimeKind.Local).AddTicks(9444)
                },
                new BeverageCategory
                {
                    Id = 2,
                    BeverageCategoryName = "Soğuk İçecek",
                    CreatedDate = new DateTime(2024, 10, 10, 21, 34, 51, 585, DateTimeKind.Local).AddTicks(9444)
                },
                new BeverageCategory
                {
                    Id = 3,
                    BeverageCategoryName = "Su",
                    CreatedDate = new DateTime(2024, 10, 10, 21, 34, 51, 585, DateTimeKind.Local).AddTicks(9444)
                });
        }
    }
}
