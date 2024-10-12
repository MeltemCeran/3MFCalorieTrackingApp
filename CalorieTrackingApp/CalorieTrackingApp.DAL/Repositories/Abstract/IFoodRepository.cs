using CalorieTrackingApp.DAL.Entities.Concrete;
using CalorieTrackingApp.DAL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieTrackingApp.DAL.Repositories.Abstract
{
    public interface IFoodRepository : IReposıtory<Food>, IDisposable
    {
        public ICollection<Food> GetFoodName(string name);

        public ICollection<Food> GetFoodCalorie(decimal calorie);

        public ICollection<Food> GetFoodCategoryId(int id);

        public ICollection<Food> GetFoodCategory(FoodCategory foodCategory);
    }
}
