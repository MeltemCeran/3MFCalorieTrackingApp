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
        void Create(TModel entity);
        void Update(TModel entity);

        void Delete(TModel entity); //SOFT DELETE

        void Delete(int id);

        IQueryable<TModel> GetAll();

        public TModel GetById(int id);
    }
}
