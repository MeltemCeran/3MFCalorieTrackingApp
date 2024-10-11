using CalorieTrackingApp.DAL.Entities.Concrete;
using CalorieTrackingApp.DAL.EntityConfiguration;
using CalorieTrackingApp.DAL.ValueObject;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieTrackingApp.DAL.Context
{
    public class CalorieDbContext : DbContext
    {
        string meltemConnectionString =
            @"Server=LAPTOP-3HH2461E;
            Database=CalorieTrackingDb;
            Trusted_Connection=true;
            Trustservercertificate=true";
        string mustafaConnectionString= @"Server=DESKTOP-U76CSFK\ANK18MSSQLSERVER;
            Database=CalorieTrackingDb;
            Trusted_Connection=true;
            Trustservercertificate=true";
        string merveConnectionString = @"server=DESKTOP-9TSVMB4;
            database=CalorieTrackingDb;
            trusted_connection=true;
            trustservercertificate=true";
        public DbSet<User> Users { get; set; }
        public DbSet<Food> Foods { get; set; }
        public DbSet<Beverage> Beverages { get; set; }
        public DbSet<FoodCategory> FoodCategories { get; set; }
        public DbSet<BeverageCategory> BeverageCategories { get; set; }
        public DbSet<Meal> Meals { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Portion> Portions { get; set; }



        //Buradan itibaren viewler olacak
        public DbSet<UserMealDailyFoodRecord> UsersMealFoodRecords { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(meltemConnectionString);

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            configurationReferance(modelBuilder);

            modelBuilder.Entity<Food>()
                        .HasOne(f => f.Portion)
                        .WithMany(p => p.Foods)
                        .HasForeignKey(f => f.PortionId)
                        .OnDelete(DeleteBehavior.NoAction); // Cascade silmeyi kapatıyoruz

            modelBuilder.Entity<Beverage>()
                        .HasOne(b => b.Portion)
                        .WithMany(p => p.Beverages)
                        .HasForeignKey(b => b.PortionId)
                        .OnDelete(DeleteBehavior.NoAction); // Cascade silmeyi kapatıyoruz
        }

        private static void configurationReferance(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AdminConfiguration());
            modelBuilder.ApplyConfiguration(new BeverageConfiguration());
            modelBuilder.ApplyConfiguration(new BeverageCategoryConfiguration());
            modelBuilder.ApplyConfiguration(new DailyUserRecordConfiguration());
            modelBuilder.ApplyConfiguration(new FoodConfiguration());
            modelBuilder.ApplyConfiguration(new FoodCategoryConfiguration());
            modelBuilder.ApplyConfiguration(new MealConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());

            modelBuilder.Entity<UserMealDailyFoodRecord>().ToView("vwUserMealDailyFoodRecord");
        }

        /*
         
        DailyUserRecord metotları örneği var hepsini ona göre genişlet.
        viewler oluşturuldu.
        userİnfo sınıfı olacak ve adminle user kullanıcı tablosunda birleşecek.
        
        
        Sorular
            DailyUserRecordRepolarındaki metotların kontrolü? Dosyada bir soru daha var oraya geçince görürsün.
            Porsiyonlar tablo mu olmalı?0
            DailyUserRecord BaseEntityden kalıtım almazsa olmuyor?? CompositeKey yapamıyorum :(
            User ve Admin tablolarında farklı proplarım var bunları soyur bir sınıfla mı ayırmalıyım? 
            UserType tablosunda admin ve user ı birleştirebilmek için buna ihtiyacım var? 

            Repository de where baseentity yerine IEntity yaptım her yer kırmızı oldu.

            Birtek usertype işi kaldı.

        ******Bura halloldu sorular kısmı.
            
         

        Kendime notlar **burdayız.
            Bir tane yeni klasör açılacak rapor sonuçları classlarının olduğu. 
            Sonra bu classların raporlama sorguları cross table a metot olarak yazılacak. 
            Tabi bu metot için view oluşturmak gerek.
            Sonrasında service katmanından BLL e geçecekler onun öncesinde unitofwork ile bağlanacak service klasörüne geçecek
            BLL de bu rapor classlarının modelleri olacak. Manager kısmında ise oluşturulan view kullanılacak sadece view kısmı!!!
            Bu view aşağıdaki repository kısmında Where vs kullanılarak daha da filtrelenecek.

            Sorguyu yazdığımı düşünüyorum sadece Group by dan öncesi modelde sonrası DailyUserReportReposunda olacaktı
            O kısımdan emin olamadım sadece.

        YAPTIKLARIM
            Portion ve Meal tablolarını oluşturdum portionları çoka  olacak şekilde food ve beverage ile birleştirdim.
            DailyUserREport metotlarında düzenlemeler yaptım. ICollection çağırıp parametre olarak tek bir değişken verilmişti.
            Birkaç karmaşık migration attım.. :( Şimdi meal ve portion için repo,service ve unmitofwork işlerini yapıp kapatıyorum.

            Meal için repository oluşturdum unitofwork ekledim service oluşturdum.
            Portion için repository oluşturdum unitofwork ekledim service oluşturdum.
         */


        /*
                     migrationBuilder.Sql(@"
            CREATE VIEW vWUserMealCalories AS
            SELECT 
                dur.UserId,
                m.MealName,
                SUM(f.FoodCalorie * p.Value) AS TotalFoodCalories,
                SUM(b.BeverageCalorie * p.Value) AS TotalBeverageCalories,
                (SUM(f.FoodCalorie * p.Value) + SUM(b.BeverageCalorie * p.Value)) AS TotalCalories,
                dur.RecordDate
            FROM DailyUserRecord dur
            JOIN Users u ON dur.UserId = u.Id
            JOIN Meals m ON dur.MealId = m.Id
            JOIN Foods f ON dur.FoodId = f.Id
            LEFT JOIN Beverages b ON dur.BeverageId = b.Id
            JOIN Portions p ON p.FoodId = f.Id OR p.BeverageId = b.Id
            GROUP BY dur.UserId, m.MealName, dur.RecordDate;
        ");

        protected override void Down(MigrationBuilder migrationBuilder)
        {
        migrationBuilder.Sql("DROP VIEW IF EXISTS UserMealCalories");
        }


         */


    }
}
