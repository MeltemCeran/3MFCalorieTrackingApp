using CalorieTrackingApp.DAL.Context;
using CalorieTrackingApp.DAL.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieTrackingApp.DAL.Services.Concrete
{
    public class ReportService
    {
        private readonly CalorieDbContext _context;
        public ReportService()
        {
            _context = new CalorieDbContext();
        }

        public ICollection<UserMealDailyFoodRecord> GetReport()
        {
            return _context.UsersMealFoodRecords.ToList();
        }
    }
}
