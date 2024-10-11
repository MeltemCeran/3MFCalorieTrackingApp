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
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(u => u.Name)
                .IsRequired()
                .HasMaxLength(30);

            builder.Property(u => u.Surname)
                .IsRequired()
                .HasMaxLength(30);

            builder.Property(u => u.Email)
            .IsRequired()
            .HasColumnType("varchar(50)");

            builder.Property(u => u.Password)
            .IsRequired()
            .HasColumnType("varchar(20)");

            builder.Property(u => u.UserName)
            .IsRequired()
            .HasColumnType("varchar(30)");
        }
    }
}
