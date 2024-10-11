using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieTrackingApp.DAL.ValueObject
{
    public class TotalCalorie
    {
        public int UserId { get; set; }
        public string MealName { get; set; }
        public decimal TotalCalories { get; set; }
        public DateOnly RecordDate { get; set; }
    }
}
