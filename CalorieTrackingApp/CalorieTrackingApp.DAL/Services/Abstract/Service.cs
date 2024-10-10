using AutoMapper;
using CalorieTrackingApp.DAL.Context;
using CalorieTrackingApp.DAL.Entities.Abstract;
using CalorieTrackingApp.DAL.Entities.Concrete;
using CalorieTrackingApp.DAL.Repositories.Abstract;
using CalorieTrackingApp.DAL.UnitOfWorks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieTrackingApp.DAL.Services.Abstract
{
    public class Service<TModel, TEntity> : IDisposable, IService<TModel>
        where TModel : class
        where TEntity : BaseEntity
    {
        private protected readonly IUnitOfWork _unitOfWork;
        private protected IReposıtory<TEntity> _repository;
        private AutoMapper.IConfigurationProvider _config;
        private IMapper _mapper;

        private bool disposed = false;

        public Service()
        {
            CalorieDbContext calorieDbContext = new CalorieDbContext();

            _unitOfWork = new UnitOfWork(calorieDbContext);
            _config = new MapperConfiguration(cfg => { cfg.CreateMap<TModel, TEntity>().ReverseMap(); });
            _mapper = new Mapper(_config);
        }

        public void Create(TModel model)
        {
            TEntity entity = _mapper.Map<TEntity>(model);
            _repository.Create(entity);
        }
        public void Update(TModel model)
        {
            TEntity entity = _mapper.Map<TEntity>(model);
            _repository.Update(entity);
        }

        public void Delete(TModel model)
        {
            TEntity entity = _mapper.Map<TEntity>(model);
            _repository.Delete(entity);
        }

        public void Delete(int id)
        {
            TEntity entity = _repository.GetById(id);
            _repository.Create(entity);
        }
        public ICollection<TModel> GetAll()
        {
            IQueryable<TEntity> entities = _repository.GetAll();
            ICollection<TModel> models = _mapper.Map<ICollection<TModel>>(entities);

            return models;
        }

        public TModel GetById(int id)
        {
            TEntity entity = _repository.GetById(id);
            TModel model = _mapper.Map<TModel>(entity);

            return model;
        }
        public int Save()
        {
            return _unitOfWork.Complete();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                   _unitOfWork.Dispose();
                    _repository.Dispose();
                }
            }
            this.disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
