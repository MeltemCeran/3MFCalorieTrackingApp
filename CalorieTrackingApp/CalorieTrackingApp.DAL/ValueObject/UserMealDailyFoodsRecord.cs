using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieTrackingApp.DAL.ValueObject
{
    [Keyless]
    public class UserMealDailyFoodsRecord
    {
        public int UserId { get; set; }
        public string MealName { get; set; }
        public string FoodName { get; set; }
        public int FoodCalorie { get; set; }
        public decimal Value { get; set; }
        public DateOnly RecordDate { get; set; }
    }
}
