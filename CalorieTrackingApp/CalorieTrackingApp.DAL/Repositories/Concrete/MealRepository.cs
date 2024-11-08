﻿using CalorieTrackingApp.DAL.Entities.Concrete;
using CalorieTrackingApp.DAL.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieTrackingApp.DAL.Repositories.Concrete
{
    public class MealRepository : Repository<Meal>, IMealRepository, IDisposable
    {
        public MealRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
