using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieTrackingApp.DAL.ValueObject
{
    [Keyless]
    public class UserMealDailyBeverageRecord
    {
        public int UserId { get; set; }
        public string MealName { get; set; }
        public float BeverageCalorie { get; set; }
        public decimal Value { get; set; }
        public DateOnly RecordDate { get; set; }
    }
}
