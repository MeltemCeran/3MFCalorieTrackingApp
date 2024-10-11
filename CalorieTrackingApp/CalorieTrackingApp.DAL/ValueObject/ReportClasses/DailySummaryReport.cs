using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieTrackingApp.DAL.ValueObject.ReportClasses
{
    public class DailySummaryReport
    {
        public int UserId { get; set; }
        public string MealName { get; set; }
        public DateOnly RecordDate { get; set; } 
        public int TotalCalories { get; set; } 
        public float TotalDailyCalories { get; set; }
        public int TotalFoodItems { get; set; } 
        public ICollection<FoodConsumption> FoodItems { get; set; } 
    }
}
