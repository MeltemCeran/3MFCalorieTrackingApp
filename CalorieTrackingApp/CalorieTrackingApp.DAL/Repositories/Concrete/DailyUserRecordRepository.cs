using CalorieTrackingApp.DAL.Entities.Concrete;
using CalorieTrackingApp.DAL.Enums;
using CalorieTrackingApp.DAL.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieTrackingApp.DAL.Repositories.Concrete
{
    public class DailyUserRecordRepository : Repository<DailyUserRecord>
    {
        public DailyUserRecordRepository(DbContext dbContext) : base(dbContext)
        {

        }

        public ICollection<DailyUserRecord> GetUsers(User user)
        {
            return _entities.Where(d => d.Users == user).ToList();
        }

        public ICollection<DailyUserRecord> GetMeals(Meal meal)
        {
            return _entities.Where(d => d.Meals == meal).ToList();
        }

        public ICollection<DailyUserRecord> GetFoods(Food food)
        {
            return _entities.Where(d => d.Foods == food).ToList();
        }

        public ICollection<DailyUserRecord> GetFoodPortions(Portion portion)
        {
            return _entities.Where(d => d.FoodPortions == portion).ToList();
        }

        public ICollection<DailyUserRecord> GetBeverages(Beverage beverage)
        {
            return _entities.Where(d => d.Beverages == beverage).ToList();
        }

        public ICollection<DailyUserRecord> GetBeveragePortions(Portion portion)
        {
            return _entities.Where(d => d.BeveragesPortions == portion).ToList();
        }
    }
}
