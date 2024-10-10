using CalorieTrackingApp.DAL.Entities.Concrete;
using CalorieTrackingApp.DAL.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieTrackingApp.DAL.Services.Concrete
{
    public class FoodService<TModel> : Service<TModel, Food>
        where TModel : class
    {
        public FoodService()
        {
            _repository = _unitOfWork.Foods;
        }
    }
}
