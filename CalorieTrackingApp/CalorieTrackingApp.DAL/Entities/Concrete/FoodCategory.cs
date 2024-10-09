using CalorieTrackingApp.DAL.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieTrackingApp.DAL.Entities.Concrete
{
    public class FoodCategory : BaseEntity
    {
        public string FoodCategoryName { get; set; }
        //public virtual ICollection<DailyUserRecord> FoodCategoryRecord { get; set; } = new List<DailyUserRecord>();
        public virtual ICollection<Food> Foods { get; set; } = new List<Food>();
    }
}
