using CalorieTrackingApp.DAL.Entities.Concrete;
using CalorieTrackingApp.DAL.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieTrackingApp.DAL.Services.Concrete
{
    public class MealService<TModel> : Service<TModel, Meal>
        where TModel : class
    {
        public MealService()
        {
            _repository = _unitOfWork.Meals;
        }
    }
}
