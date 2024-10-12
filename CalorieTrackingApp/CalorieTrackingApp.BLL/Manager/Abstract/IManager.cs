using CalorieTrackingApp.DAL.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieTrackingApp.BLL.Manager.Abstract
{
    public interface IManager<TModel> :IDisposable where TModel : class
    {
        void Create(TModel model);
        void Update(TModel model);
        void Delete(TModel model); //SOFT DELETE
        void Delete(int id);
        ICollection<TModel> GetAll();
        public TModel GetById(int id);
        int Save();
    }
}
