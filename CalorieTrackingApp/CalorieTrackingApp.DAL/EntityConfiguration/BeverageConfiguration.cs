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
            builder.Property(b => b.BeverageName)
            .IsRequired()
            .HasColumnType("varchar(30)");// nvarchar olacak

        }
    }
}
