using CalorieTrackingApp.DAL.Entities.Concrete;
using CalorieTrackingApp.DAL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieTrackingApp.DAL.Repositories.Abstract
{
    public interface IFoodRepository : IReposıtory<Food>
    {
        public ICollection<Food> GetFoodName(string name);

        public ICollection<Food> GetFoodCalorie(float calorie);

        public ICollection<Food> GetPortion(Portion portion);

        public ICollection<Food> GetFoodCategoryId(int id);

        public ICollection<Food> GetFoodCategory(FoodCategory foodCategory);
    }
}
