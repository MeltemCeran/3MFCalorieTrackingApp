using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieTrackingApp.DAL.ValueObject
{
    public class UserMealFoodCalorieGroup
    {
        public int UserId { get; set; }
        public string MealName { get; set; }
        public decimal TotalFoodCalorie { get; set; }
        public DateOnly RecordDate { get; set; }
    }
}
