using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieTrackingApp.DAL.Enums
{
    public enum Meal 
    {
        [Description("Kahvaltı")]
        Breakfast = 1,
        [Description("Öğle Yemeği")]
        Lunch = 2,
        [Description("Ara Öğün")]
        Snack = 3,
        [Description("Akşam Yemeği")]
        Dinner = 4,  
    }
}
