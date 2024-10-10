using CalorieTrackingApp.DAL.Entities.Concrete;
using CalorieTrackingApp.DAL.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieTrackingApp.DAL.Services.Concrete
{
    public class DailyUserRecordService<TModel> : Service<TModel,DailyUserRecord>
        where TModel : class
    {
        public DailyUserRecordService()
        {
            _repository = _unitOfWork.DailyUserRecords;
        }
    }
}
