using CalorieTrackingApp.BLL.Models.Abstract;
using CalorieTrackingApp.DAL.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieTrackingApp.BLL.Models.Concrete
{
    public class MealModel : BaseViewModel
    {
        public string MealName { get; set; }
        public virtual ICollection<DailyUserRecord> MealsRecords { get; set; } = new List<DailyUserRecord>();

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
