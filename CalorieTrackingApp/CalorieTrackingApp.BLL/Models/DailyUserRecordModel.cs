using CalorieTrackingApp.DAL.Entities.Concrete;
using CalorieTrackingApp.DAL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieTrackingApp.BLL.Models
{
    public class DailyUserRecordModel
    {
        public int Id { get; set; }
        public User Users { get; set; }
        public Meal Meals { get; set; }
        //public FoodCategory FoodCategories { get; set; }
        public Food Foods { get; set; }
        public Portion FoodPortions { get; set; }
        //public BeverageCategory BeverageCetegories { get; set; }
        public Beverage Beverages { get; set; }
        public Portion BeveragesPortions { get; set; }
    }
}
