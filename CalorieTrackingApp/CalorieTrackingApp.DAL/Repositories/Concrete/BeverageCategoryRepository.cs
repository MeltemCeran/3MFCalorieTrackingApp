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
    public class BeverageCategoryRepository : Repository<BeverageCategory>
    {
        public BeverageCategoryRepository(DbContext dbContext) : base(dbContext)
        {

        }

        public ICollection<BeverageCategory> GetBeverageCategoryName(string name)
        {
            return _entities.Where(bcn => bcn.BeverageCategoryName == name).ToList();
        }
    }
}
