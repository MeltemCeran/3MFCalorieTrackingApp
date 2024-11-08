﻿using CalorieTrackingApp.DAL.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CalorieTrackingApp.DAL.Repositories.Abstract
{
    public interface IReposıtory<TEntity> : IDisposable where TEntity : BaseEntity
    {
        void Create(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity); //SOFT DELETE
        void Delete(int id);
        IQueryable<TEntity> GetAll();
        public TEntity GetById(int id);

    }
}
