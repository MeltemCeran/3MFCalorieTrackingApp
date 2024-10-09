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
    public abstract class Repository<TEntity> : IReposıtory<TEntity> where TEntity : BaseEntity
    {
        private protected DbContext _dbContext;
        private protected DbSet<TEntity> _entities;

        protected Repository(DbContext dbContext)
        {
            _dbContext = dbContext;
            _entities = _dbContext.Set<TEntity>();
        }

        //ALP HOCANIN YAPTIĞI ? ARADAKİ FARK?
        //private readonly CalorieDbContext _db;
        //private DbSet<TEntity> _entities;

        //public Repository(CalorieDbContext db)
        //{
        //    _db = db;
        //    _entities = _db.Set<TEntity>();
        //}

        public void Create(TEntity entity)
        {
            entity.DataStatus = DataStatus.Inserted;
            entity.CreatedDate = DateTime.Now;
            _entities.Add(entity);
            _dbContext.SaveChanges();
        }

        public void Delete(TEntity entity)
        {
            entity.DataStatus = DataStatus.Deleted;
            entity.DeletedDate = DateTime.Now;
            Update(entity);
        }

        public void Delete(int id)
        {
            TEntity entity = _entities.Where(s => s.Id == id).ToList().SingleOrDefault();

            Delete(entity);
        }

        public IQueryable<TEntity> GetAll()
        {
            return _entities.Where(e => e.DataStatus != DataStatus.Deleted).AsNoTracking();
        }

        //İçerisine TEntity olarak gönderdiğimiz her ne olursa olsun, BÜTÜN navigation'larını include ETSİN.
        public IQueryable<TEntity> GetAllWithIncludes()
        {
            IQueryable<TEntity> query = _dbContext.Set<TEntity>();

            TEntity instance = new TEntity(); //Dinamik SORGU? Özelleştirilmiş SORGU?

            Type type = instance.GetType();

            var propertyInfos = type.GetProperties();

            foreach (var propertyInfo in propertyInfos.Where(pi => pi.PropertyType.GetInterfaces().Where(i => i.Name == "IEntity" || i.Name == "IList").Any()).ToList())
            {
                if (propertyInfo.Name != "Denemeler")
                    query = query.Include(propertyInfo.Name);
            }
            return query;
        }

        public IQueryable<TEntity> GetAllWithIncludes(params string[] navigationProperties)
        {
            IQueryable<TEntity> query = _dbContext.Set<TEntity>();

            foreach (var navigationProperty in navigationProperties)
            {
                query = query.Include(navigationProperty);
            }
            return query;
        }

        public TEntity GetById(int id)
        {
            //return _entities.Find(id);
            return _entities.AsNoTracking().FirstOrDefault(e => e.Id == id);
        }

        public IQueryable<TEntity> Search(Expression<Func<TEntity, bool>> searchCriteria)
        {
            var all = _entities.Where(e => e.DataStatus != DataStatus.Deleted);
            return all.Where(searchCriteria);
        }

        public void Update(TEntity entity)
        {
            // bool isBeingTracked = false;
            entity.DataStatus = entity.DataStatus != DataStatus.Deleted ?
                DataStatus.Updated : DataStatus.Deleted;
            entity.ModifiedDate = DateTime.Now;
            entity.CreatedDate = GetById(entity.Id).CreatedDate;

            //foreach (var item in _dbContext.ChangeTracker.Entries())
            //{
            //    if (item.Entity.GetType() == typeof(TEntity))
            //    {
            //        item.State = EntityState.Detached;
            //        //  isBeingTracked = true;
            //        // break;
            //    }


            //}


            _entities.Update(entity);


            _dbContext.SaveChanges();
        }
    }
}
