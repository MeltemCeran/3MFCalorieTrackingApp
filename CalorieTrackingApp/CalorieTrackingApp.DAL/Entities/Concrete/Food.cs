﻿using CalorieTrackingApp.DAL.Entities.Abstract;
using CalorieTrackingApp.DAL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieTrackingApp.DAL.Entities.Concrete
{
    public class Food : BaseEntity
    {
        public string FoodName { get; set; }
        public float FoodCalorie { get; set; }
        public Portion Portion { get; set; }
        public virtual ICollection<DailyUserRecord> FoodRecords { get; set; } = new List<DailyUserRecord>();
        public int FoodCategoryId { get; set; }
        public virtual FoodCategory FoodCategory { get; set; }

    }
}