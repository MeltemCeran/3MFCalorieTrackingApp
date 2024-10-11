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
            builder.Property(p => p.PortionType)
                .IsRequired()
                .HasMaxLength(15);

            builder.Property(p => p.Value)
                .IsRequired()
                .HasColumnType("decimal(2, 2)");

            builder.Property(p => p.ProductType)
                .IsRequired()
                .HasMaxLength(15);

            builder.HasData(
                new Portion
                {
                    Id = 1,
                    PortionType = "Porsiyon",
                    Value = 100,
                    ProductType = "Yiyecek",
                    CreatedDate = new DateTime(2024, 10, 10, 21, 34, 51, 585, DateTimeKind.Local).AddTicks(9444)
                },
                new Portion
                {
                    Id = 2,
                    PortionType = "Tabak",
                    Value = 1,
                    ProductType = "Yiyecek",
                    CreatedDate = new DateTime(2024, 10, 10, 21, 34, 51, 585, DateTimeKind.Local).AddTicks(9444)
                },
                new Portion
                {
                    Id = 3,
                    PortionType = "Adet",
                    Value = 1,
                    ProductType = "",
                    CreatedDate = new DateTime(2024, 10, 10, 21, 34, 51, 585, DateTimeKind.Local).AddTicks(9444)
                },
                new Portion
                {
                    Id = 4,
                    PortionType = "Dilim",
                    Value = 1,
                    ProductType = "",
                    CreatedDate = new DateTime(2024, 10, 10, 21, 34, 51, 585, DateTimeKind.Local).AddTicks(9444)
                },
                new Portion
                {
                    Id = 5,
                    PortionType = "Fincan",
                    Value = 1,
                    ProductType = "",
                    CreatedDate = new DateTime(2024, 10, 10, 21, 34, 51, 585, DateTimeKind.Local).AddTicks(9444)
                },
                new Portion
                {
                    Id = 6,
                    PortionType = "Bardak(ml)",
                    Value = 1,
                    ProductType = "",
                    CreatedDate = new DateTime(2024, 10, 10, 21, 34, 51, 585, DateTimeKind.Local).AddTicks(9444)
                });
        }
    }
}
