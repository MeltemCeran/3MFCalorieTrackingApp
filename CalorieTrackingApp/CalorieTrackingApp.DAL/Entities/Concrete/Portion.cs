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
        public int BeverageId { get; set; }
        public Beverage Beverage { get; set; }
        public int FoodId { get; set; }
        public Food Food { get; set; }
    }
}
