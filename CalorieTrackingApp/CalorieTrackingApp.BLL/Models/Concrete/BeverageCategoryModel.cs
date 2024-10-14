using CalorieTrackingApp.BLL.Models.Abstract;
using CalorieTrackingApp.DAL.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieTrackingApp.BLL.Models.Concrete
{
    public class BeverageCategoryModel : BaseViewModel
    {
        public string BeverageCategoryName { get; set; }
        public virtual ICollection<Beverage> Beverages { get; set; } = new List<Beverage>();

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
