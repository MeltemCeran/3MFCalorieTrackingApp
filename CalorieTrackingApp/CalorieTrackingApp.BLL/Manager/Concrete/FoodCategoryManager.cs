﻿using CalorieTrackingApp.BLL.Manager.Abstract;
using CalorieTrackingApp.BLL.Models.Concrete;
using CalorieTrackingApp.DAL.Services.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieTrackingApp.BLL.Manager.Concrete
{
    public class FoodCategoryManager : Manager<FoodCategoryModel, FoodCategoryService<FoodCategoryModel>>
    {
        protected FoodCategoryManager(DbContext dbContext) : base(dbContext)
        {
        }
    }
}