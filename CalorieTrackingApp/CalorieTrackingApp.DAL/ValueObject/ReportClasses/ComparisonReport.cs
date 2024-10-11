using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieTrackingApp.DAL.ValueObject.ReportClasses
{
    public class ComparisonReport
    {
        public int UserId { get; set; } 
        public string MealName { get; set; }
        public int TotalCalories { get; set; }
        public DateOnly StartDate { get; set; } 
        public DateOnly EndDate { get; set; } 
        public Dictionary<DateOnly, int> DailyCalories { get; set; } 
    }
}
