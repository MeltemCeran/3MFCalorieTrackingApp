﻿using CalorieTrackingApp.DAL.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieTrackingApp.DAL.Repositories.Abstract
{
    public interface IBeverageCategoryRepository : IReposıtory<BeverageCategory>, IDisposable
    {
        public ICollection<BeverageCategory> GetBeverageCategoryName(string name);
    }
}
