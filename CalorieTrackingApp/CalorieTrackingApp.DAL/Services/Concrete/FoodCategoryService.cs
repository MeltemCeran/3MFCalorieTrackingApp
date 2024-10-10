using CalorieTrackingApp.DAL.Entities.Concrete;
using CalorieTrackingApp.DAL.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieTrackingApp.DAL.Services.Concrete
{
    public class FoodCategoryService<TModel> : Service<TModel,FoodCategory>
        where TModel : class
    {
        public FoodCategoryService()
        {
            _repository = _unitOfWork.FoodCategories;
        }
    }
}
