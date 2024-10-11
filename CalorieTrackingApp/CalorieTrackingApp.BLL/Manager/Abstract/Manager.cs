﻿using CalorieTrackingApp.DAL.Entities.Abstract;
using CalorieTrackingApp.DAL.Enums;
using CalorieTrackingApp.DAL.Services.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieTrackingApp.BLL.Manager.Abstract
{
    public class Manager<TModel,TService>:IDisposable,IManager<TModel>
        where TModel : class 
        where TService : IService<TModel>,new()
    {
        private protected readonly TService _service;
        private bool disposed = false;
        

        protected Manager(DbContext dbContext)
        {
            _service = new TService();
        }

        public void Create(TModel model)
        {
            _service.Create(model);
        }

        public void Update(TModel model)
        {
            _service.Update(model);
        }

        public void Delete(TModel model)
        {
            _service.Delete(model);
        }

        public void Delete(int id)
        {
            _service.Delete(id);
        }

        

        public TModel GetById(int id)
        {
            return _service.GetById(id);
        }
        //Buraları alp hocanınkilerle karşılaştırıp datastatus ayarlarına bakalım.
        //Datastatus güncellemeleri yapılacak.

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _service.Dispose();
                }
            }
            this.disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        IQueryable<TModel> IManager<TModel>.GetAll()
        {
           return _service.GetAll().AsQueryable();
        }
    }
}