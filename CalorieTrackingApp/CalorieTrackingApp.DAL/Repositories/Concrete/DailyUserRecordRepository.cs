using CalorieTrackingApp.DAL.Entities.Concrete;
using CalorieTrackingApp.DAL.Enums;
using CalorieTrackingApp.DAL.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieTrackingApp.DAL.Repositories.Concrete
{
    public class DailyUserRecordRepository : Repository<DailyUserRecord>, IDailyUserRecordRepository
    {
        public DailyUserRecordRepository(DbContext dbContext) : base(dbContext)
        {

        }

        //public ICollection<User> GetUsersRecords(int userId = default(int), DateOnly date = default(DateOnly))
        //{
        //    IQueryable<DailyUserRecord> query = _entities.Include(dur => dur.Users);

        //    if(userId != default(int))
        //        query = query.Where(u => u.UserId == userId);

        //    if (date != default(DateOnly))
        //        query = query.Where(u => u.RecordDate == date);

        //    return query
        //        .GroupBy(g => new { g.Users, g.RecordDate })
        //        .Select(s => new User { Name = s.Key.Users.Name, DailyUserRecordDate = s.Key.RecordDate, CountDailyUserRecord = s.Count() })
        //        .ToList();

        //    //Bu metot, belirli bir kullanıcıya ve/veya tarihe göre DailyUserRecord kayıtlarını getirip,
        //    //her kullanıcı ve gün için kaç tane kayıt bulunduğunu bir User nesnesi koleksiyonu olarak döner.
        //}

        //public ICollection<User> GetUsersMontlyCalorie(int userId = default(int), int year = default(int), int month = default(int))
        //{
        //    IQueryable<DailyUserRecord> query = _entities.Include(dur => dur.Users)
        //                                                  .Include(dur => dur.Foods); // Gıda bilgilerini de dahil et

        //    // Kullanıcı ID'sine göre filtreleme
        //    if (userId != default(int))
        //        query = query.Where(u => u.UserId == userId);

        //    // Yıl ve ay bazında filtreleme
        //    if (year != default(int) && month != default(int))
        //    {
        //        var startDate = new DateOnly(year, month, 1); // Ayın ilk günü
        //        var endDate = startDate.AddMonths(1).AddDays(-1); // Ayın son günü
        //        query = query.Where(u => u.RecordDate >= startDate && u.RecordDate <= endDate);
        //    }

        //    return query
        //        .GroupBy(g => new { g.Users, Year = g.RecordDate.Year, Month = g.RecordDate.Month })
        //        .Select(s => new User
        //        {
        //            Name = s.Key.Users.Name,
        //            Surname = s.Key.Users.Surname,
        //            CountDailyUserRecord = s.Count(),
        //            MonthlyCalorieTotal = s.Sum(dailyrecord => dailyrecord.FoodCalorie) // Aylık kalori toplamını hesapla
        //        })
        //        .ToList();
        //}
       
    }
}
