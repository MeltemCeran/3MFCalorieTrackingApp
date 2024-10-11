using CalorieTrackingApp.DAL.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieTrackingApp.DAL.Entities.Concrete
{
    public class Meal : BaseEntity
    {
        public string MealName { get; set; }
        public virtual ICollection<DailyUserRecord> MealsRecords { get; set; } = new List<DailyUserRecord>();
        public virtual ICollection<MealFood> MealFoods { get; set; } 
    }
}
