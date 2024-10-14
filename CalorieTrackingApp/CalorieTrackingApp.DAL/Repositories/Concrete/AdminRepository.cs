using CalorieTrackingApp.DAL.Entities.Concrete;
using CalorieTrackingApp.DAL.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieTrackingApp.DAL.Repositories.Concrete
{
    public class AdminRepository : Repository<Admin>, IAdminRepository,IDisposable
    {
        public AdminRepository(DbContext dbContext) : base(dbContext)
        {

        }

        public ICollection<Admin> GetAdminName(string adminName)
        {
            return _entities.Where(an => an.AdminName == adminName).ToList();
        }

        public ICollection<Admin> GetName(string name)
        {
            return _entities.Where(an => an.Name == name).ToList();
        }

        public ICollection<Admin> GetSurname(string surname)
        {
            return _entities.Where(an => an.Surname == surname).ToList();
        }
    }
}
