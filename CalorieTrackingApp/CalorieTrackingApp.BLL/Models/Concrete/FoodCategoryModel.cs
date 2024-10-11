using CalorieTrackingApp.BLL.Models.Abstract;
using CalorieTrackingApp.DAL.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieTrackingApp.BLL.Models.Concrete
{
    public class FoodCategoryModel: BaseViewModel
    {
        public int Id { get; set; }
        public string FoodCategoryName { get; set; }
        //public virtual ICollection<DailyUserRecord> FoodCategoryRecord { get; set; } = new List<DailyUserRecord>();
        public virtual ICollection<Food> Foods { get; set; } = new List<Food>();
    }
}
