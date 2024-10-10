using CalorieTrackingApp.DAL.Entities.Concrete;
using CalorieTrackingApp.DAL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieTrackingApp.DAL.Repositories.Abstract
{
    public interface IUserRepository : IReposıtory<User>
    {
        public ICollection<User> GetName(string name);

        public ICollection<User> GetSurname(string surname);

        public ICollection<User> GetEmail(string email);

        public ICollection<User> GetUserName(string userName);

        public ICollection<User> GetUserAgeGap(AgeGap ageGap);

        public ICollection<User> GetUserGoal(Goal goal);

    }
}
