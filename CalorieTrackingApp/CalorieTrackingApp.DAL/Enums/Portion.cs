using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieTrackingApp.DAL.Enums
{
    public enum Portion
    {
        [Description("Adet")]
        piece =1,
        [Description("Porsiyon")]
        serving =2,
        [Description("Plate")]
        plate =3,
        Kg = 4,
        Ml = 5,
    }
}
