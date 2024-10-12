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
    public class DailyUserRecordConfiguration : IEntityTypeConfiguration<DailyUserRecord>
    {
        public void Configure(EntityTypeBuilder<DailyUserRecord> builder)
        {
            builder.Property(dur => dur.RecordDate).HasColumnType("date");

            builder.HasData(
                new DailyUserRecord
                {
                    Id = 1,
                    UserId = 1,
                    MealId = 1,
                    CreatedDate = new DateTime(2024, 10, 10, 21, 34, 51, 585, DateTimeKind.Local).AddTicks(9444),
                    BeverageId = 2,
                    FoodId = 16,
                    RecordDate = new DateOnly(2024,10,10),
                    PortionId = 3,
                },
                new DailyUserRecord
                {
                    Id = 2,
                    UserId = 2,
                    MealId = 2,
                    CreatedDate = new DateTime(2024, 10, 10, 21, 34, 51, 585, DateTimeKind.Local).AddTicks(9444),
                    BeverageId = 9,
                    FoodId = 10,
                    RecordDate = new DateOnly(2024, 10, 10),
                    PortionId = 1,
                },
                new DailyUserRecord
                {
                    Id = 3,
                    UserId = 3,
                    MealId = 4,
                    CreatedDate = new DateTime(2024, 10, 10, 21, 34, 51, 585, DateTimeKind.Local).AddTicks(9444),
                    BeverageId = 7,
                    FoodId = 12,
                    RecordDate = new DateOnly(2024, 10, 10),
                    PortionId = 1,
                });
        }
    }
}
