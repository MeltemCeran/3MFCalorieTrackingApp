using CalorieTrackingApp.DAL.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieTrackingApp.BLL.Models
{
    public class BeverageCategoryModel
    {
        public int Id { get; set; }
        public string BeverageCategoryName { get; set; }
        //public virtual ICollection<DailyUserRecord> BeverageCategoryRecords { get; set; } = new List<DailyUserRecord>();
        public virtual ICollection<Beverage> Beverages { get; set; } = new List<Beverage>();
    }
}
