using CalorieTrackingApp.DAL.Entities.Concrete;
using CalorieTrackingApp.DAL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieTrackingApp.BLL.Models
{
    public class BeverageModel
    {
        public int Id { get; set; }
        public string BeverageName { get; set; }
        public float BeverageCalorie { get; set; }
        public Portion Portion { get; set; }
        public virtual ICollection<DailyUserRecord> BeverageRecords { get; set; } = new List<DailyUserRecord>();
        public int BeverageCategoryId { get; set; }
        public virtual BeverageCategory BeverageCategory { get; set; }
    }
}
