using CalorieTrackingApp.BLL.Models.Abstract;
using CalorieTrackingApp.DAL.Entities.Concrete;
using CalorieTrackingApp.DAL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieTrackingApp.BLL.Models.Concrete
{
    public class DailyUserRecordModel: BaseViewModel
    {
        public int UserId { get; set; }
        public int MealId { get; set; }
        public int FoodId { get; set; }
        public int BeverageId { get; set; }
        public virtual User Users { get; set; }
        public virtual Meal Meals { get; set; }
        public virtual Food Foods { get; set; }
        public virtual Beverage Beverages { get; set; }
        public DateOnly RecordDate { get; set; }
        public int PortionId { get; set; }
        public virtual Portion Portions { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
