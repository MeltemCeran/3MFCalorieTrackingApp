using CalorieTrackingApp.DAL.Entities.Abstract;
using CalorieTrackingApp.DAL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieTrackingApp.DAL.Entities.Concrete
{
    public class Beverage : BaseEntity
    {
        public string BeverageName { get; set; }
        public float BeverageCalorie { get; set; }
        public virtual Portion Portion { get; set; }
        public int PortionId { get; set; }
        public virtual ICollection<DailyUserRecord> BeverageRecords { get; set; } = new List<DailyUserRecord>();
        public int BeverageCategoryId { get; set; }
        public virtual BeverageCategory BeverageCategory { get; set; }
    }
}
