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
            builder.Property(bc => bc.BeverageCategoryName)
                .IsRequired()
                .HasMaxLength(30);
        }
    }
}
