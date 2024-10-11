using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieTrackingApp.DAL.Entities.Concrete
{
    public class MealFood
    {
        public int MealId { get; set; }
        public int FoodId { get; set; }
        public virtual Meal Meal { get; set; }
        public virtual Food Food { get; set; }
    }
}
