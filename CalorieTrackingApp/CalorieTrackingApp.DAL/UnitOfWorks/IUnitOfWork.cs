using CalorieTrackingApp.DAL.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieTrackingApp.DAL.UnitOfWorks
{
    public interface IUnitOfWork : IDisposable
    {
        //Tamamlandı
        IAdminRepository Admins { get; }
        IBeverageCategoryRepository BeverageCategories { get; }
        IBeverageRepository Beverages { get; }
        IDailyUserRecordRepository DailyUserRecords { get; }
        IFoodCategoryRepository FoodCategories { get; }
        IFoodRepository Foods { get; }
        IUserRepository Users { get; }

        int Complete();
    }
}
