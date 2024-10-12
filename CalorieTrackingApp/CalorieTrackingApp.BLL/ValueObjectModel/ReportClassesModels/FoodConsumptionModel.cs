using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieTrackingApp.BLL.ValueObjectModel.ReportClassesModels
{
    public class FoodConsumptionModel
    {
        public string MealName { get; set; }
        public string FoodName { get; set; }
        public int Quantity { get; set; }
        public int TotalConsumed { get; set; }
        public decimal TotalCalories { get; set; }
        public string MealType { get; set; }
    }
}
