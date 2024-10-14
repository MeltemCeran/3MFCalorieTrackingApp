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
    public class BeverageRepository : Repository<Beverage>, IBeverageRepository, IDisposable
    {
        public BeverageRepository(DbContext dbContext) : base(dbContext)
        {

        }

        public ICollection<Beverage> GetBeverageName(string name)
        {
            return _entities.Where(b => b.BeverageName == name).ToList();
        }

        public ICollection<Beverage> GetBeverageCalorie(decimal calorie)
        {
            return _entities.Where(b => b.BeverageCalorie == calorie).ToList();
        }

        public ICollection<Beverage> GetBeverageCategoryId(int id)
        {
            return _entities.Where(b => b.BeverageCategoryId == id).ToList();
        }

        public ICollection<Beverage> GetBeverageCategory(BeverageCategory beverageCategory)
        {
            return _entities.Where(b => b.BeverageCategory == beverageCategory).ToList();
        }
    }
}
