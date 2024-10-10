using CalorieTrackingApp.DAL.Context;
using CalorieTrackingApp.DAL.Entities.Abstract;
using CalorieTrackingApp.DAL.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CalorieTrackingApp.DAL.Repositories.Abstract
{
    public abstract class Repository<TEntity> : IReposıtory<TEntity>, IDisposable where TEntity : BaseEntity
    {
        private protected DbContext _dbContext;
        private protected DbSet<TEntity> _entities;
        private bool disposed = false;

        protected Repository(DbContext dbContext)
        {
            _dbContext = dbContext;
            _entities = _dbContext.Set<TEntity>();
        }

        public void Create(TEntity entity)
        {
            entity.DataStatus = DataStatus.Inserted;
            //entity.CreatedDate = DateTime.Now; - BaseEntityde datetime.now eklendi çalışmazsa burayı açarız.
            _entities.Add(entity);
        }

        public void Update(TEntity entity)
        {
            entity.DataStatus = entity.DataStatus != DataStatus.Deleted ?
                DataStatus.Updated : DataStatus.Deleted;
            entity.ModifiedDate = DateTime.Now;
            _entities.Update(entity);

        }

        public void Delete(TEntity entity)
        {
            entity.DataStatus = DataStatus.Deleted;
            entity.DeletedDate = DateTime.Now;
            _entities.Update(entity);
            
        }

        public void Delete(int id)
        {
            TEntity? entity = _entities.AsNoTracking().Where(s => s.Id == id).ToList().SingleOrDefault();

            Delete(entity);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IQueryable<TEntity> GetAll()
        {
            return _entities.Where(e => e.DataStatus != DataStatus.Deleted).AsNoTracking();
        }

        
    }
}
