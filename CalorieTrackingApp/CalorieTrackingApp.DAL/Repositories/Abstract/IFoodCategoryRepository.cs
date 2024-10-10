﻿using CalorieTrackingApp.DAL.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieTrackingApp.DAL.Repositories.Abstract
{
    public interface IFoodCategoryRepository : IReposıtory<FoodCategory>
    {
        public ICollection<FoodCategory> GetFoodCategoryName(string name);
    }
}
