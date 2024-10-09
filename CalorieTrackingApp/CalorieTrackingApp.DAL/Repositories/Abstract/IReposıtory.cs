using CalorieTrackingApp.DAL.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CalorieTrackingApp.DAL.Repositories.Abstract
{
    public interface IReposıtory<TEntity> where TEntity : BaseEntity
    {
        void Create(TEntity entity);

        void Update(TEntity entity);

        void Delete(TEntity entity); //SOFT DELETE

        void Delete(int id);

        IQueryable<TEntity> GetAll();

        TEntity GetById(int id);

        IQueryable<TEntity> Search(Expression<Func<TEntity, bool>> searchCriteria);

        public IQueryable<TEntity> GetAllWithIncludes();

        public IQueryable<TEntity> GetAllWithIncludes(params string[] navigationProperties);
    }
}
