using CalorieTrackingApp.DAL.Entities.Abstract;
using CalorieTrackingApp.DAL.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieTrackingApp.DAL.Entities.Concrete
{
    public class User : BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }
        public virtual ICollection<DailyUserRecord> UserRecords { get; set; } = new List<DailyUserRecord>();
        public AgeGap UserAgeGap { get; set; }
        public Goal UserGoal { get; set; }

        [NotMapped]
        public int CountDailyUserRecord { get; set; }

        [NotMapped]
        public DateOnly DailyUserRecordDate { get; set; }

        [NotMapped]
        public int MonthlyCalorieTotal { get; set; }

    }
}
