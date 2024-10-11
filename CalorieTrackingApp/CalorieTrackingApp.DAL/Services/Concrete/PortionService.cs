using CalorieTrackingApp.DAL.Entities.Concrete;
using CalorieTrackingApp.DAL.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieTrackingApp.DAL.Services.Concrete
{
    public class PortionService<TModel> : Service<TModel,Portion>
        where TModel : class
    {
        public PortionService()
        {
            _repository = _unitOfWork.Portions;
        }
    }
}
