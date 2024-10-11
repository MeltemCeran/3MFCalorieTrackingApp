using CalorieTrackingApp.DAL.Entities.Abstract;
using CalorieTrackingApp.DAL.Enums;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieTrackingApp.DAL.Entities.Concrete
{
    public class DailyUserRecord : BaseEntity
    {
        public int UserId { get; set; }
        public int MealId { get; set; }
        public int FoodId { get; set; }
        public int BeverageId { get; set; }
        public virtual User Users { get; set; }
        public virtual Meal Meals { get; set; }
        public virtual Food Foods { get; set; }
        public virtual Beverage Beverages { get; set; }
        public DateOnly RecordDate { get; set; }

        //öğün tarihi eklenecek // eklendi
        //where baseentity yazan yerler IEntity olsun
        //öğün tablo olsun --oldu
        //Dailyuserrecord Id almayacak fluent api ya da data annotationla [key] yazıp composit key yap. // yaptım
        //Porsiyonlara birim koyulacak. tablo olabailir?
    }
}
