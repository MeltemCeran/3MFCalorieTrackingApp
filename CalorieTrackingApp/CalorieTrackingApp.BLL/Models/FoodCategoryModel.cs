using CalorieTrackingApp.DAL.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieTrackingApp.BLL.Models
{
    public class FoodCategoryModel
    {
        public int Id { get; set; }
        public string FoodCategoryName { get; set; }
        //public virtual ICollection<DailyUserRecord> FoodCategoryRecord { get; set; } = new List<DailyUserRecord>();
        public virtual ICollection<Food> Foods { get; set; } = new List<Food>();
    }
}
