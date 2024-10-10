using CalorieTrackingApp.DAL.Entities.Concrete;
using CalorieTrackingApp.DAL.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieTrackingApp.DAL.Services.Concrete
{
    public class BeverageCategoryService<TModel> : Service<TModel,BeverageCategory>
        where TModel : class
    {
        public BeverageCategoryService()
        {
            _repository = _unitOfWork.BeverageCategories;
        }
    }
}
