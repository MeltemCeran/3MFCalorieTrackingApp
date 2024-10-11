﻿using CalorieTrackingApp.DAL.Entities.Concrete;
using CalorieTrackingApp.DAL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieTrackingApp.DAL.Repositories.Abstract
{
    public interface IBeverageRepository : IReposıtory<Beverage>, IDisposable
    {
        public ICollection<Beverage> GetBeverageName(string name);

        public ICollection<Beverage> GetBeverageCalorie(float calorie);

        public ICollection<Beverage> GetBeverageCategoryId(int id);

        public ICollection<Beverage> GetBeverageCategory(BeverageCategory beverageCategory);
    }
}
