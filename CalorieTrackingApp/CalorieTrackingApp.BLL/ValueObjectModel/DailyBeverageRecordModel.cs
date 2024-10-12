using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieTrackingApp.BLL.ValueObjectModel
{
    public class DailyBeverageRecordModel
    {
        public int UserId { get; set; }
        public string MealName { get; set; }
        public string BeverageName { get; set; }
        public decimal BeverageCalorie { get; set; }
        public decimal Value { get; set; }
        public DateOnly RecordDate { get; set; }
    }
}
