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
    public class FoodModel : BaseViewModel
    {
        public string FoodName { get; set; }
        public decimal FoodCalorie { get; set; }
        public int PortionId { get; set; }
        public virtual Portion Portion { get; set; }
        public virtual ICollection<DailyUserRecord> FoodRecords { get; set; } = new List<DailyUserRecord>();
        public int FoodCategoryId { get; set; }
        public virtual FoodCategory FoodCategory { get; set; }
    }
}
