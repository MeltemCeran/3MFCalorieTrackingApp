using CalorieTrackingApp.DAL.Entities.Concrete;
using CalorieTrackingApp.DAL.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieTrackingApp.DAL.Services.Concrete
{
    public class UserService<TModel> : Service<TModel ,User>
        where TModel : class
    {
        public UserService()
        {
            _repository = _unitOfWork.Users;
        }
    }
}
