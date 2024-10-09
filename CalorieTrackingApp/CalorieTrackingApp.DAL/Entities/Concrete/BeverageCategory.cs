using CalorieTrackingApp.DAL.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieTrackingApp.DAL.Entities.Concrete
{
    public class BeverageCategory : BaseEntity
    {
        public string BeverageCategoryName { get; set; }
        //public virtual ICollection<DailyUserRecord> BeverageCategoryRecords { get; set; } = new List<DailyUserRecord>();
        public virtual ICollection<Beverage> Beverages { get; set; } = new List<Beverage>();
    }
}
