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
    public class BeverageConfiguration : IEntityTypeConfiguration<Beverage>
    {
        public void Configure(EntityTypeBuilder<Beverage> builder)
        {
            builder.Property(b => b.BeverageName).HasColumnType("nvarchar(30)");

            builder.Property(b => b.BeverageCalorie).HasColumnType("decimal(7, 2)");

            builder.HasData(
                new Beverage
                {
                    Id = 1,
                    BeverageName = "Su",
                    CreatedDate = new DateTime(2024, 10, 10, 21, 34, 51, 585, DateTimeKind.Local).AddTicks(9444),
                    BeverageCalorie = 0,
                    BeverageCategoryId = 3,
                    PortionId = 5
                },
                new Beverage
                {
                    Id = 2,
                    BeverageName = "Sade Türk Kahvesi",
                    CreatedDate = new DateTime(2024, 10, 10, 21, 34, 51, 585, DateTimeKind.Local).AddTicks(9444),
                    BeverageCalorie = 2,
                    BeverageCategoryId = 1,
                    PortionId = 4
                },
                new Beverage
                {
                    Id = 3,
                    BeverageName = "Orta Türk Kahvesi",
                    CreatedDate = new DateTime(2024, 10, 10, 21, 34, 51, 585, DateTimeKind.Local).AddTicks(9444),
                    BeverageCalorie = 15,
                    BeverageCategoryId = 1,
                    PortionId = 4
                },
                new Beverage
                {
                    Id = 4,
                    BeverageName = "Şekerli Türk Kahvesi",
                    CreatedDate = new DateTime(2024, 10, 10, 21, 34, 51, 585, DateTimeKind.Local).AddTicks(9444),
                    BeverageCalorie = 25,
                    BeverageCategoryId = 1,
                    PortionId = 4
                },
                new Beverage
                {
                    Id = 5,
                    BeverageName = "Kola",
                    CreatedDate = new DateTime(2024, 10, 10, 21, 34, 51, 585, DateTimeKind.Local).AddTicks(9444),
                    BeverageCalorie = 149,
                    BeverageCategoryId = 2,
                    PortionId = 6
                },
                new Beverage
                {
                    Id = 6,
                    BeverageName = "Light veya Zero Kola",
                    CreatedDate = new DateTime(2024, 10, 10, 21, 34, 51, 585, DateTimeKind.Local).AddTicks(9444),
                    BeverageCalorie = 1,
                    BeverageCategoryId = 2,
                    PortionId = 6
                },
                new Beverage
                {
                    Id = 7,
                    BeverageName = "Soğuk Çay",
                    CreatedDate = new DateTime(2024, 10, 10, 21, 34, 51, 585, DateTimeKind.Local).AddTicks(9444),
                    BeverageCalorie = 60,
                    BeverageCategoryId = 2,
                    PortionId = 6
                },
                new Beverage
                {
                    Id = 8,
                    BeverageName = "Light veya Zero Soğuk Çay",
                    CreatedDate = new DateTime(2024, 10, 10, 21, 34, 51, 585, DateTimeKind.Local).AddTicks(9444),
                    BeverageCalorie = 10,
                    BeverageCategoryId = 2,
                    PortionId = 6
                },
                new Beverage
                {
                    Id = 9,
                    BeverageName = "Şalgam(Acılı)",
                    CreatedDate = new DateTime(2024, 10, 10, 21, 34, 51, 585, DateTimeKind.Local).AddTicks(9444),
                    BeverageCalorie = 40,
                    BeverageCategoryId = 2,
                    PortionId = 5
                });
        }
    }
}
