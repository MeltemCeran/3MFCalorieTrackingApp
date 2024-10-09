using CalorieTrackingApp.DAL.Entities.Concrete;
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
        public DbSet<User> Users { get; set; }
        public DbSet<Food> Foods { get; set; }
        public DbSet<Beverage> Beverages { get; set; }
        public DbSet<FoodCategory> FoodCategories { get; set; }
        public DbSet<BeverageCategory> BeverageCategories { get; set; }
        public DbSet<Admin> Admins { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(meltemConnectionString);
        }
    }
}
