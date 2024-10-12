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
    public class BeverageModel: BaseViewModel
    {
        public string BeverageName { get; set; }
        public decimal BeverageCalorie { get; set; }
        public virtual Portion Portion { get; set; }
        public int PortionId { get; set; }
        public virtual ICollection<DailyUserRecord> BeverageRecords { get; set; } = new List<DailyUserRecord>();
        public int BeverageCategoryId { get; set; }
        public virtual BeverageCategory BeverageCategory { get; set; }
    }
}
