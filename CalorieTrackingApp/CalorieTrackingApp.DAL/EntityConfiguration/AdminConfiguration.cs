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
    public class AdminConfiguration : IEntityTypeConfiguration<Admin>
    {
        public void Configure(EntityTypeBuilder<Admin> builder)
        {
            builder.Property(a => a.AdminName).HasColumnType("varchar(30)");

            builder.Property(a => a.Password).HasColumnType("varchar(20)");

            builder.Property(a => a.Name).HasColumnType("nvarchar(30)");

            builder.Property(a => a.Surname).HasColumnType("nvarchar(30)");

            builder.HasData(
                new Admin
                {
                    Id = 1,
                    AdminName = "admin",
                    Password = "admin123",
                    Name = "Admin_Name",
                    Surname = "Admin_Surname",
                    CreatedDate = new DateTime(2024, 10, 10, 21, 34, 51, 585, DateTimeKind.Local).AddTicks(9444)
                    //Her çalıştığında create date i oluşturmaması için sabit bir değer koyduk bu değer üzerinden çalışacak.
                    //Her seferinde yeni seed data oluşturmasın diye.
                });
        }
    }
}