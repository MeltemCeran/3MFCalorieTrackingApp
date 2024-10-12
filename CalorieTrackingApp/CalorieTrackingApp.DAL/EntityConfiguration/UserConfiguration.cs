using CalorieTrackingApp.DAL.Entities.Concrete;
using CalorieTrackingApp.DAL.Enums;
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
            builder.Property(u => u.Name).HasColumnType("nvarchar(30)");

            builder.Property(u => u.Surname).HasColumnType("nvarchar(30)");

            builder.Property(u => u.Email).HasColumnType("varchar(50)");

            builder.Property(u => u.Password).HasColumnType("varchar(20)");

            builder.Property(u => u.UserName).HasColumnType("varchar(30)");

            builder.HasData(
                new User
                {
                    Id = 1,
                    Name = "Kazım Göksel",
                    Surname = "Kalyoncu",
                    Email = "kgkalyoncu@mail.com",
                    Password = "kgk*user",
                    UserName = "kgkalyoncu@mail.com", //"KGokselKalyoncu",
                    CreatedDate = new DateTime(2024, 10, 10, 21, 34, 51, 585, DateTimeKind.Local).AddTicks(9444),
                    UserAgeGap = (AgeGap)4,
                    UserGoal = (Goal)2

                },
                new User
                {
                    Id = 2,
                    Name = "Alp",
                    Surname = "Ceyhan",
                    Email = "alpceyhan@mail.com",
                    Password = "alp*user",
                    UserName = "alpceyhan@mail.com", //"AlpCeyhan",
                    CreatedDate = new DateTime(2024, 10, 10, 21, 34, 51, 585, DateTimeKind.Local).AddTicks(9444),
                    UserAgeGap = (AgeGap)4,
                    UserGoal = (Goal)2
                },
                new User
                {
                    Id = 3,
                    Name = "Yahya Alkın",
                    Surname = "Bayrak",
                    Email = "alkinbayrak@mail.com",
                    Password = "ayb*user",
                    UserName = "alkinbayrak@mail.com", //"AlkinBayrak",
                    CreatedDate = new DateTime(2024, 10, 10, 21, 34, 51, 585, DateTimeKind.Local).AddTicks(9444),
                    UserAgeGap = (AgeGap)3,
                    UserGoal = (Goal)3
                },
                new User
                {
                    Id = 4,
                    Name = "Minel",
                    Surname = "Karakökçek",
                    Email = "minelk@mail.com",
                    Password = "minelk*user",
                    UserName = "minelk@mail.com", //"MinelK",
                    CreatedDate = new DateTime(2024, 10, 10, 21, 34, 51, 585, DateTimeKind.Local).AddTicks(9444),
                    UserAgeGap = (AgeGap)2,
                    UserGoal = (Goal)3
                },
                new User
                {
                    Id = 5,
                    Name = "Efnan",
                    Surname = "Genç",
                    Email = "efnan@mail.com",
                    Password = "efnan*user",
                    UserName = "efnan@mail.com", //"EfnanGenc",
                    CreatedDate = new DateTime(2024, 10, 10, 21, 34, 51, 585, DateTimeKind.Local).AddTicks(9444),
                    UserAgeGap = (AgeGap)1,
                    UserGoal = (Goal)3
                });
        }
    }
}
