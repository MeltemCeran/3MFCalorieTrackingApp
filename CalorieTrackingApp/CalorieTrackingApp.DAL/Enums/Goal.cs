using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieTrackingApp.DAL.Enums
{
    public enum Goal
    {
        [Description("Kilo Vermek")]
        LoosingWeight = 1,
        [Description("Sağlıklı Yaşam")]
        HealthyLifestyle = 2,
        [Description("Öğünlerimi Düzenlemek")]
        MealArrangement = 3,
    }
}
