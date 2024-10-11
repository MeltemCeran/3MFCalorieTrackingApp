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
    public class DailyUserRecordRepository : Repository<DailyUserRecord>, IDailyUserRecordRepository
    {
        public DailyUserRecordRepository(DbContext dbContext) : base(dbContext)
        {

        }

        public ICollection<User> GetUsers(int userId = default(int), DateOnly date = default(DateOnly))
        {
            //return (ICollection<User>)_entities.AsNoTracking().ToList(); //İllaki cast etmemi istedi neden olabilir?

            IQueryable<DailyUserRecord> query = _entities.Include(dur => dur.Users);

            if(userId != default(int))
                query = query.Where(u => u.UserId == userId);

            if (date != default(DateOnly))
                query = query.Where(u => u.RecordDate == date);

            return query
                .GroupBy(g => new { g.Users, g.RecordDate })
                .Select(s => new User { Name = s.Key.Users.Name, DailyUserRecordDate = s.Key.RecordDate, CountDailyUserRecord = s.Count() })
                .ToList();
        }
        public ICollection<User> GetUserById(int userId)
        {
            return (ICollection<User>)_entities.AsNoTracking().Where(d => d.UserId == userId).ToList();
        }

        public ICollection<Meal> GetMeals(string name)
        {
            return (ICollection<Meal>)_entities.Include(d => d.Meals).Where(d => d.Meals.MealName == name).ToList();
        }

        public ICollection<Food> GetFoods()
        {
            return (ICollection<Food>)_entities.AsNoTracking().ToList();
        }

        public ICollection<Food> GetFoodById(int foodId)
        {
            return (ICollection<Food>)_entities.Where(d => d.FoodId == foodId).ToList();
        }
        public ICollection<Beverage> GetBeverages()
        {
            return (ICollection<Beverage>)_entities.AsNoTracking().ToList();
        }
        public ICollection<Beverage> GetBeverageById(int beverageId)
        {
            return (ICollection<Beverage>)_entities.Where(d => d.BeverageId == beverageId).ToList();
        }

        //public ICollection<DailyUserRecord> GetDailyReport(User user,Meal meal,Food food)
        //{
        //    _dbContext.VwaaaT.
        //}
    }
}
