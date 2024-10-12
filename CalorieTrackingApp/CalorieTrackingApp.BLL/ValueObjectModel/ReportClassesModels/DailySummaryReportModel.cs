using CalorieTrackingApp.DAL.ValueObject.ReportClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieTrackingApp.BLL.ValueObjectModel.ReportClassesModels
{
    public class DailySummaryReportModel
    {
        public int UserId { get; set; }
        public string MealName { get; set; }
        public DateOnly RecordDate { get; set; }
        public int TotalCalories { get; set; }
        public decimal TotalDailyCalories { get; set; }
        public int TotalFoodItems { get; set; }
        public ICollection<FoodConsumption> FoodItems { get; set; }
    }
}
