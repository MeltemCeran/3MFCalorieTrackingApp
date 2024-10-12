using CalorieTrackingApp.BLL.Manager.Abstract;
using CalorieTrackingApp.BLL.Models.Concrete;
using CalorieTrackingApp.DAL.Context;
using CalorieTrackingApp.DAL.Services.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieTrackingApp.BLL.Manager.Concrete
{
    public class AdminManager : Manager<AdminModel, AdminService<AdminModel>>
    {

    }
}
