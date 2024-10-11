using CalorieTrackingApp.DAL.Entities.Concrete;
using CalorieTrackingApp.DAL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieTrackingApp.DAL.Repositories.Abstract
{
    public interface IDailyUserRecordRepository : IReposıtory<DailyUserRecord>, IDisposable
    {
        public ICollection<User> GetUsers(int userId, DateOnly date);
        public ICollection<User> GetUserById(int userId);
        public ICollection<Meal> GetMeals(string name);
        public ICollection<Food> GetFoods();
        public ICollection<Food> GetFoodById(int foodId);
        public ICollection<Beverage> GetBeverages();
        public ICollection<Beverage> GetBeverageById(int beverageId);
    }
}
