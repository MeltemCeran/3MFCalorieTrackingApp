using CalorieTrackingApp.DAL.Repositories.Abstract;
using CalorieTrackingApp.DAL.Repositories.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieTrackingApp.DAL.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        //Tamamlandı
        private DbContext _dbContext;
        private bool disposed;

        public UnitOfWork(DbContext dbContext)
        {
            _dbContext = dbContext;

            Admins = new AdminRepository(_dbContext);
            BeverageCategories = new BeverageCategoryRepository(_dbContext);
            Beverages = new BeverageRepository(_dbContext);
            DailyUserRecords = new DailyUserRecordRepository(_dbContext);
            FoodCategories = new FoodCategoryRepository(_dbContext);
            Foods = new FoodRepository(_dbContext);
            Users = new UserRepository(_dbContext);
            Meals = new MealRepository(_dbContext);
            Portions = new PortionRepository(_dbContext);
        }

        public IAdminRepository Admins { get; private set; }

        public IBeverageCategoryRepository BeverageCategories { get; private set; }

        public IBeverageRepository Beverages { get; private set; }

        public IDailyUserRecordRepository DailyUserRecords { get; private set; }

        public IFoodCategoryRepository FoodCategories { get; private set; }

        public IFoodRepository Foods { get; private set; }

        public IUserRepository Users { get; private set; }

        public IMealRepository Meals { get; private set; }

        public IPortionRepository Portions { get; private set; }

        public int Complete()
        {
            int affectedRows = _dbContext.SaveChanges();
            return affectedRows;
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _dbContext.Dispose();
                    Admins.Dispose();
                }
            }
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
