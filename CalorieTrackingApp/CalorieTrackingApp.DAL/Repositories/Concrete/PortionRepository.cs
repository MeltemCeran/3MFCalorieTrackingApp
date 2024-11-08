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
    public class PortionRepository : Repository<Portion>, IPortionRepository, IDisposable
    {
        public PortionRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
