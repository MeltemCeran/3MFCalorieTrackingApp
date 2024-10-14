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
    public class UserModel: BaseViewModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }
        public virtual ICollection<DailyUserRecord> UserRecords { get; set; } = new List<DailyUserRecord>();
        public AgeGap UserAgeGap { get; set; }
        public Goal UserGoal { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
