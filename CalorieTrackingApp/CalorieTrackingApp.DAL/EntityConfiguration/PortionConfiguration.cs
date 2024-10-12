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
    public class PortionConfiguration : IEntityTypeConfiguration<Portion>
    {
        public void Configure(EntityTypeBuilder<Portion> builder)
        {
            builder.Property(p => p.PortionType).HasColumnType("nvarchar(15)");

            builder.Property(p => p.Value).HasColumnType("decimal(2, 2)");

            builder.Property(p => p.ProductType).HasColumnType("nvarchar(15)");

            builder.HasData(
                new Portion
                {
                    Id = 1,
                    PortionType = "Porsiyon(gr)",
                    Value = 125,
                    CreatedDate = new DateTime(2024, 10, 10, 21, 34, 51, 585, DateTimeKind.Local).AddTicks(9444),
                    ProductType = "Yiyecek"
                },
                new Portion
                {
                    Id = 2,
                    PortionType = "Adet(tane)",
                    Value = 1,
                    CreatedDate = new DateTime(2024, 10, 10, 21, 34, 51, 585, DateTimeKind.Local).AddTicks(9444),
                    ProductType = "Yiyecek"
                },
                new Portion
                {
                    Id = 3,
                    PortionType = "Dilim(tane)",
                    Value = 1,
                    CreatedDate = new DateTime(2024, 10, 10, 21, 34, 51, 585, DateTimeKind.Local).AddTicks(9444),
                    ProductType = "Yiyecek"
                },
                new Portion
                {
                    Id = 4,
                    PortionType = "Fincan(ml)",
                    Value = 100,
                    CreatedDate = new DateTime(2024, 10, 10, 21, 34, 51, 585, DateTimeKind.Local).AddTicks(9444),
                    ProductType = "İçecek"
                },
                new Portion
                {
                    Id = 5,
                    PortionType = "Kupa Bardak(ml)",
                    Value = 200,
                    CreatedDate = new DateTime(2024, 10, 10, 21, 34, 51, 585, DateTimeKind.Local).AddTicks(9444),
                    ProductType = "İçecek"
                },
                new Portion
                {
                    Id = 6,
                    PortionType = "Kutu(ml)",
                    Value = 330,
                    CreatedDate = new DateTime(2024, 10, 10, 21, 34, 51, 585, DateTimeKind.Local).AddTicks(9444),
                    ProductType = "İçecek"
                },
                new Portion
                {
                    Id = 7,
                    PortionType = "Çay Kaşığı(gr)",
                    Value = 5,
                    CreatedDate = new DateTime(2024, 10, 10, 21, 34, 51, 585, DateTimeKind.Local).AddTicks(9444),
                    ProductType = "Yiyecek"
                });
        }
    }
}
