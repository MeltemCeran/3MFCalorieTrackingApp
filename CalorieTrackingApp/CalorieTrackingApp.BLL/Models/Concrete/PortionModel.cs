using CalorieTrackingApp.BLL.Models.Abstract;
using CalorieTrackingApp.DAL.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieTrackingApp.BLL.Models.Concrete
{
    public class PortionModel : BaseViewModel
    {
        public string PortionType { get; set; }
        public decimal Value { get; set; }
        public virtual ICollection<Beverage> Beverages { get; set; } = new List<Beverage>();
        public virtual ICollection<Food> Foods { get; set; } = new List<Food>();
        public string ProductType { get; set; }
        public virtual ICollection<DailyUserRecord> PortionRecords { get; set; } = new List<DailyUserRecord>();

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
