using CalorieTrackingApp.DAL.Entities.Concrete;
using CalorieTrackingApp.DAL.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieTrackingApp.DAL.Services.Concrete
{
    public class BeverageService<TModel> : Service<TModel,Beverage>
        where TModel : class
    {
        public BeverageService()
        {
            _repository = _unitOfWork.Beverages;
        }
    }
}
