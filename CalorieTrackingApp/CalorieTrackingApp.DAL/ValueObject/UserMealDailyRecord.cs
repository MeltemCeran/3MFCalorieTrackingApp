using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieTrackingApp.DAL.ValueObject
{
    public class UserMealDailyRecord
    {
        public int UserId { get; set; }
        public string MealName { get; set; }
        public int MyProperty { get; set; }
        public float FoodCalorie { get; set; }
        public decimal Value {  get; set; }
    }
}
