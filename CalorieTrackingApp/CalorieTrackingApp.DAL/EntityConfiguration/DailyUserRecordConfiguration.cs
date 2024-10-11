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
            
        }
    }
}
