using CalorieTrackingApp.DAL.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieTrackingApp.DAL.Entities.Concrete
{
    public class Portion : BaseEntity
    {
        public string PortionType { get; set; }
        public decimal Value { get; set; }
        public virtual ICollection<Beverage> Beverages { get; set; } = new List<Beverage>();
        public virtual ICollection<Food> Foods { get; set; } = new List<Food>();
    }
}
