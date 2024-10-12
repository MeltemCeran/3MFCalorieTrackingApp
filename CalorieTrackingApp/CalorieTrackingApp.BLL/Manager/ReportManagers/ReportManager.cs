using AutoMapper;
using CalorieTrackingApp.BLL.ValueObjectModel;
using CalorieTrackingApp.BLL.ValueObjectModel.ReportClassesModels;
using CalorieTrackingApp.DAL.Entities.Concrete;
using CalorieTrackingApp.DAL.Services.ReportServices;
using CalorieTrackingApp.DAL.ValueObject;
using CalorieTrackingApp.DAL.ValueObject.ReportClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieTrackingApp.BLL.Manager.ReportManagers
{
    public class ReportManager
    {
        private protected readonly ReportService _reportService;
        private IConfigurationProvider _config;
        private IMapper _mapper;

        public ReportManager()
        {
            _reportService = new ReportService();
            _config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<TotalCalorie, TotalCalorieModel>();
                cfg.CreateMap<UserMealBeverageCalorieGroup, BeverageCalorieGroupModel>();
                cfg.CreateMap<UserMealDailyBeverageRecord, DailyBeverageRecordModel>();
                cfg.CreateMap<UserMealDailyFoodRecord, DailyFoodRecordModel>();
                cfg.CreateMap<UserMealFoodCalorieGroup, FoodCalorieGroupModel>();
                //Ekstra sorgu viewleri için config ayarları
                cfg.CreateMap<WeeklyCalorieReport, WeeklyCalorieReportModel>();
                cfg.CreateMap<FoodConsumption, FoodConsumptionModel>();
                cfg.CreateMap<DailySummaryReport, DailyBeverageRecordModel>();
                cfg.CreateMap<ComparisonReport, ComparisonReportModel>();
            });
            _mapper = new Mapper(_config);
        }

        public ICollection<DailySummaryReport> GetDailySummaryReports(int userId, DateTime date)
        {
            return _reportService.GetDailySummaryReports(userId, date);
        }
    }
}
