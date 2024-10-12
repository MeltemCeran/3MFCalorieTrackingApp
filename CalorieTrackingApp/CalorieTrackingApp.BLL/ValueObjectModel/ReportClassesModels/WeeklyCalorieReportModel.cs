using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieTrackingApp.BLL.ValueObjectModel.ReportClassesModels
{
    public class WeeklyCalorieReportModel
    {
        public int UserId { get; set; }
        public DateOnly StartOfWeek { get; set; }
        public DateOnly EndOfWeek { get; set; }
        public DateTime Date { get; set; }
        public decimal TotalCalories { get; set; }
        public int AverageDailyCalories { get; set; }
    }
}
