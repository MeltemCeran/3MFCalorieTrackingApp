using CalorieTrackingApp.DAL.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieTrackingApp.DAL.Repositories.Abstract
{
    public interface IAdminRepository : IReposıtory<Admin>
    {
        public ICollection<Admin> GetAdminName(string adminName);

        public ICollection<Admin> GetName(string name);

        public ICollection<Admin> GetSurname(string surname);
    }
}
