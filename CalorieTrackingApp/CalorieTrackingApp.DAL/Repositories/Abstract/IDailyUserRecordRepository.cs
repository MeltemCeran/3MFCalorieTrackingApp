using CalorieTrackingApp.DAL.Entities.Concrete;
using CalorieTrackingApp.DAL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieTrackingApp.DAL.Repositories.Abstract
{
    public interface IDailyUserRecordRepository : IReposıtory<DailyUserRecord>
    {
        public ICollection<User> GetUsers(User user);

        public ICollection<Meal> GetMeals(Meal meal);

        public ICollection<Food> GetFoods(Food food);

        public ICollection<Portion> GetFoodPortions(Portion portion);

        public ICollection<Beverage> GetBeverages(Beverage beverage);

        public ICollection<Portion> GetBeveragePortions(Portion portion);
    }
}
