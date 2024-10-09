using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieTrackingApp.DAL.Enums
{
    public enum AgeGap
    {
        [Description("0-18")]
        child = 1,
        [Description("18-24")]
        teenager = 2,
        [Description("25-35")]
        young = 3,
        [Description("36-45")]
        middleAge = 4,
        [Description("46+")]
        old = 5,


    }
}
