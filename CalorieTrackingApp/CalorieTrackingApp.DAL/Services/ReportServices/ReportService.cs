using CalorieTrackingApp.DAL.Context;
using CalorieTrackingApp.DAL.ValueObject;
using CalorieTrackingApp.DAL.ValueObject.ReportClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieTrackingApp.DAL.Services.ReportServices
{
    public class ReportService
    {
        private readonly CalorieDbContext _context;
        public ReportService()
        {
            _context = new CalorieDbContext();
        }

        // 1. Gün Sonu Raporu
        public List<DailySummaryReport> GetDailySummaryReports(int userId, DateTime date)
        {
            var foodRecords = _context.UsersMealDailyFoodRecords
                .Where(r => r.UserId == userId && r.RecordDate.ToDateTime(TimeOnly.MinValue) == date.Date)
                .ToList();

            var beverageRecords = _context.UserMealDailyBeverageRecords
                .Where(r => r.UserId == userId && r.RecordDate.ToDateTime(TimeOnly.MinValue) == date.Date)
                .ToList();

            // Toplam kalori hesaplaması
            var totalCalories = foodRecords.Sum(f => f.FoodCalorie) + beverageRecords.Sum(b => b.BeverageCalorie);

            return foodRecords.Select(f => new DailySummaryReport
            {
                UserId = f.UserId,
                MealName = f.MealName,
                TotalCalories = f.FoodCalorie,
                RecordDate = f.RecordDate,
                TotalDailyCalories = totalCalories // Günlük toplam kalori
            }).ToList();
        }
        public List<ComparisonReport> GetComparisonReports(DateTime startDate, DateTime endDate)
        {
            // Haftalık/aylık bazda yemek ve içecek kıyaslaması
            var foodComparison = _context.UserMealFoodCalorieGroups
                .Where(r => r.RecordDate.ToDateTime(TimeOnly.MinValue) >= startDate && r.RecordDate.ToDateTime(TimeOnly.MinValue) <= endDate)
                .GroupBy(r => r.MealName)
                .Select(g => new ComparisonReport
                {
                    MealName = g.Key,
                    TotalCalories = g.Sum(r => r.TotalFoodCalorie)
                }).ToList();

            var beverageComparison = _context.UserMealBeverageCalorieGroups
                .Where(r => r.RecordDate.ToDateTime(TimeOnly.MinValue) >= startDate && r.RecordDate.ToDateTime(TimeOnly.MinValue) <= endDate)
                .GroupBy(r => r.MealName)
                .Select(g => new ComparisonReport
                {
                    MealName = g.Key,
                    TotalCalories = g.Sum(r => r.TotalBeverageCalorie)
                }).ToList();

            // İki listeyi birleştirin veya uygun şekilde döndürün
            return foodComparison.Concat(beverageComparison).ToList();
        }

        // 3. Yemek Çeşidi Raporu
        public List<FoodConsumption> GetFoodConsumptionReport()
        { 
            var foodConsumption = _context.UsersMealDailyFoodRecords
                .GroupBy(r => r.MealName)
                .Select(g => new FoodConsumption
                {
                    MealName = g.Key,
                    TotalConsumed = g.Count(),
                    TotalCalories = g.Sum(r => r.FoodCalorie)
                }).ToList();

            return foodConsumption;
        }

        // 4. Haftalık Kalori Raporu
        public List<WeeklyCalorieReport> GetWeeklyCalorieReport(int userId, DateTime startDate)
        {
            var weeklyReport = _context.TotalCalories
                .Where(r => r.UserId == userId && r.RecordDate.ToDateTime(TimeOnly.MinValue) >= startDate && r.RecordDate.ToDateTime(TimeOnly.MinValue) < startDate.AddDays(7))
                .GroupBy(r => r.RecordDate.ToDateTime(TimeOnly.MinValue).Date)
                .Select(g => new WeeklyCalorieReport
                {
                    Date = g.Key,
                    TotalCalories = g.Sum(r => r.TotalCalories)
                }).ToList();

            return weeklyReport;
        }
    }
}
