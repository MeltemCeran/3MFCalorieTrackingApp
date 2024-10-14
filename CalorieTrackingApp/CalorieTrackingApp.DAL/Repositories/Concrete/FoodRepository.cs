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
    public class FoodRepository : Repository<Food>, IFoodRepository, IDisposable
    {
        public FoodRepository(DbContext dbContext) : base(dbContext)
        {

        }

        public ICollection<Food> GetFoodName(string name)
        {
            return _entities.Where(f => f.FoodName == name).ToList();
        }

        public ICollection<Food> GetFoodCalorie(decimal calorie)
        {
            return _entities.Where(f => f.FoodCalorie == calorie).ToList();
        }

        public ICollection<Food> GetFoodCategoryId(int id)
        {
            return _entities.Where(f => f.FoodCategoryId == id).ToList();
        }

        public ICollection<Food> GetFoodCategory(FoodCategory foodCategory)
        {
            return _entities.Where(f => f.FoodCategory == foodCategory).ToList();
        }
    }
}
