using CalorieTrackingApp.DAL.Entities.Concrete;
using CalorieTrackingApp.DAL.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieTrackingApp.DAL.Repositories.Concrete
{
    public class FoodCategoryRepository : Repository<FoodCategory>, IFoodCategoryRepository, IDisposable
    {
        public FoodCategoryRepository(DbContext dbContext) : base(dbContext)
        {

        }

        public ICollection<FoodCategory> GetFoodCategoryName(string name)
        {
            return _entities.Where(fcn => fcn.FoodCategoryName == name).ToList();
        }
    }
}
