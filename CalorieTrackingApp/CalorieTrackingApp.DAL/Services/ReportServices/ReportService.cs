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

        //view model eklenmeli misal dailysummaryreportmodel
        //Modellerde group by vs gibi özelleştirilmiş raporları ya da farklı bir şekilde 
        //managerda mapper dailysummaryreport olacak
        //model eklenecek ve sadece mapplemesi yapılacak.
        //eğer bi filtreleme daha istersem dailysummaryreport tan bir örnek daha yapıp adını özelleştirip öyle kullanmalıyım

        // 1. Gün Sonu Raporu
        // Bu metot, belirtilen kullanıcı ve tarihe göre gün sonu raporu oluşturur. Hem yemek hem de içecek kayıtlarını kontrol eder ve toplam kalori hesabı yapar.
        public ICollection<DailySummaryReport> GetDailySummaryReports(int userId, DateTime date)
        {
            // Kullanıcının o gün yediği yemek kayıtlarını filtreliyoruz.
            // Kullanıcı ID'sine ve belirtilen tarihe göre yemek kayıtlarını getiriyoruz.
            var foodRecords = _context.UserMealDailyFoodRecords
                .Where(r => r.UserId == userId && r.RecordDate.ToDateTime(TimeOnly.MinValue) == date.Date)  // Tarih ve kullanıcı filtrelemesi
                .ToList();  // Sonuçları listeye çeviriyoruz

            // Kullanıcının o gün içtiği içecek kayıtlarını filtreliyoruz.
            // Kullanıcı ID'sine ve belirtilen tarihe göre içecek kayıtlarını getiriyoruz.
            var beverageRecords = _context.UserMealDailyBeverageRecords
                .Where(r => r.UserId == userId && r.RecordDate.ToDateTime(TimeOnly.MinValue) == date.Date)  // Tarih ve kullanıcı filtrelemesi
                .ToList();  // Sonuçları listeye çeviriyoruz

            // Toplam kalori hesaplaması yapılıyor.
            // Hem yemek hem de içecek kalorileri ayrı ayrı toplanarak toplam günlük kalori hesaplanıyor.
            var totalCalories = foodRecords.Sum(f => f.FoodCalorie) + beverageRecords.Sum(b => b.BeverageCalorie);

            // Yemek kayıtları üzerinden her bir öğün için rapor oluşturuluyor.
            return foodRecords.Select(f => new DailySummaryReport
            {
                UserId = f.UserId,  // Kullanıcı ID'si
                MealName = f.MealName,  // Yemek adı
                TotalCalories = f.FoodCalorie,  // O öğündeki toplam kalori
                RecordDate = f.RecordDate,  // Kayıt tarihi
                TotalDailyCalories = totalCalories  // O günün toplam kalorisi (yemek + içecek)
            }).ToList();  // Sonuçları listeye çeviriyoruz
        }

        // 2. Haftalık/aylık bazda yemek ve içecek kıyaslaması
        // ComparisonReport türünde bir koleksiyon döndüren metot.
        // Bu metot, verilen tarih aralığında yemek ve içeceklerin toplam kalorilerini hesaplayarak bir karşılaştırma raporu oluşturur.
        public ICollection<ComparisonReport> GetComparisonReports(DateTime startDate, DateTime endDate)
        {
            // Yemek kalori bilgilerini sorguluyoruz.
            // Belirtilen tarih aralığına göre filtreleme yapılır (startDate ve endDate arasında).
            var foodComparison = _context.UserMealFoodCalorieGroups
                .Where(r => r.RecordDate.ToDateTime(TimeOnly.MinValue) >= startDate && r.RecordDate.ToDateTime(TimeOnly.MinValue) <= endDate) // Tarih filtresi
                .GroupBy(r => r.MealName)  // Aynı yemek isimlerine göre gruplanır.
                .Select(g => new ComparisonReport
                {
                    MealName = g.Key,  // Grup içindeki yemek adı
                    TotalCalories = g.Sum(r => r.TotalFoodCalorie)  // Her gruptaki toplam yemek kalorisi
                }).ToList();  // Sonuçları listeye çeviriyoruz

            // İçecek kalori bilgilerini sorguluyoruz.
            // Yine aynı şekilde, belirtilen tarih aralığına göre filtreleme yapılır.
            var beverageComparison = _context.UserMealBeverageCalorieGroups
                .Where(r => r.RecordDate.ToDateTime(TimeOnly.MinValue) >= startDate && r.RecordDate.ToDateTime(TimeOnly.MinValue) <= endDate) // Tarih filtresi
                .GroupBy(r => r.MealName)  // Aynı içecek isimlerine göre gruplanır.
                .Select(g => new ComparisonReport
                {
                    MealName = g.Key,  // Grup içindeki içecek adı
                    TotalCalories = g.Sum(r => r.TotalBeverageCalorie)  // Her gruptaki toplam içecek kalorisi
                }).ToList();  // Sonuçları listeye çeviriyoruz

            // Yemek ve içecek raporlarını birleştiriyoruz (concat) ve tek bir liste olarak döndürüyoruz.
            return foodComparison.Concat(beverageComparison).ToList();
        }

        // 3. Yemek Çeşidi Raporu
        // Bu metot, belirtilen tarih aralığında yemek ve içecek tüketim raporunu oluşturur.
        public ICollection<FoodConsumption> GetFoodAndDrinkConsumptionReport(DateTime startDate, DateTime endDate)
        {
            // Yemekler (UsersMealDailyFoodRecords view)
            // Belirtilen tarih aralığındaki yemek kayıtlarını filtreliyoruz.
            // 'RecordDate' tarihinin startDate ile endDate arasında olup olmadığını kontrol ediyoruz.
            var foodConsumption = _context.UserMealDailyFoodRecords
                .Where(r => r.RecordDate.ToDateTime(TimeOnly.MinValue) >= startDate && r.RecordDate.ToDateTime(TimeOnly.MinValue) <= endDate)  // Tarih filtresi
                .GroupBy(r => r.MealName)  // Yemek ismine göre gruplama yapıyoruz.
                .Select(g => new FoodConsumption
                {
                    MealName = g.Key,  // Grup anahtarını (yemek adı) alıyoruz.
                    MealType = "Yemek",  // Bu verilerin yemek olduğunu belirtiyoruz.
                    TotalConsumed = g.Count(),  // Toplam tüketim sayısını alıyoruz.
                    TotalCalories = g.Sum(r => r.FoodCalorie)  // Toplam kalori hesaplaması yapıyoruz.
                });

            // İçecekler (UserMealDailyBeverageRecord view)
            // Belirtilen tarih aralığındaki içecek kayıtlarını filtreliyoruz.
            var drinkConsumption = _context.UserMealDailyBeverageRecords
                .Where(r => r.RecordDate.ToDateTime(TimeOnly.MinValue) >= startDate && r.RecordDate.ToDateTime(TimeOnly.MinValue) <= endDate)  // Tarih filtresi
                .GroupBy(r => r.BeverageName)  // İçecek ismine göre gruplama yapıyoruz.
                .Select(g => new FoodConsumption
                {
                    MealName = g.Key,  // Grup anahtarını (içecek adı) alıyoruz.
                    MealType = "İçecek", // Bu verilerin içecek olduğunu belirtiyoruz.
                    TotalConsumed = g.Count(),  // Toplam tüketim sayısını alıyoruz.
                    TotalCalories = g.Sum(r => r.BeverageCalorie)  // Toplam kalori hesaplaması yapıyoruz.
                });

            // Yemek ve içecekleri birleştiriyoruz
            // İki sorgudan elde edilen sonuçları birleştiriyoruz.
            var combinedConsumption = foodConsumption
                .Union(drinkConsumption)  // İki sorguyu birleştiriyoruz.
                .ToList();  // Sonuçları listeye çeviriyoruz.

            // Birleşik yemek ve içecek tüketim raporunu döndürüyoruz.
            return combinedConsumption;  // Sonuçları döndürüyoruz.
        }

        // 4.Haftalık Kalori Raporu
        // Bu metot, belirtilen kullanıcı için belirtilen başlangıç tarihinden itibaren 7 gün boyunca toplam kalori tüketimini raporlar.
        public ICollection<WeeklyCalorieReport> GetWeeklyCalorieReport(int userId, DateTime startDate)
        {
            // Haftalık rapor oluşturuyoruz.
            var weeklyReport = _context.TotalCalories
                // Kullanıcıya özel ve başlangıç tarihine göre filtreleme yapıyoruz.
                .Where(r => r.UserId == userId &&
                            r.RecordDate.ToDateTime(TimeOnly.MinValue) >= startDate &&
                            r.RecordDate.ToDateTime(TimeOnly.MinValue) < startDate.AddDays(7))  // 7 günlük tarih aralığı
                .GroupBy(r => r.RecordDate.ToDateTime(TimeOnly.MinValue).Date)  // Kayıt tarihine göre gruplama yapıyoruz.
                .Select(g => new WeeklyCalorieReport
                {
                    Date = g.Key,  // Grup anahtarını (tarih) alıyoruz.
                    TotalCalories = g.Sum(r => r.TotalCalories)  // Her grup için toplam kalori hesaplıyoruz.
                }).ToList();  // Sonuçları listeye çeviriyoruz.

            // Haftalık kalori raporunu döndürüyoruz.
            return weeklyReport;  // Raporu döndürüyoruz.


            //NOTLAR 
            /*
             UI Kısmı için
            Hata Yönetimi
            Kullanıcıların girdiği tarihler gibi parametrelerde hata kontrolü yapman faydalı olabilir.
            Örneğin, başlangıç tarihi bitiş tarihinden sonra olamaz.         
             
             */
        }
    }
}
