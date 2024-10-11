using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieTrackingApp.DAL.ValueObject.ReportClasses
{
    public class WeeklyCalorieReport
    {
        public int UserId { get; set; } 
        public DateOnly StartOfWeek { get; set; } 
        public DateOnly EndOfWeek { get; set; }
        public DateTime Date { get; set; }
        public decimal TotalCalories { get; set; } 
        public int AverageDailyCalories { get; set; } 
    }
}
