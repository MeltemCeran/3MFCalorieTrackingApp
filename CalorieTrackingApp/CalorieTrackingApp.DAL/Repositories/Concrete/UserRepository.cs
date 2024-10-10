using CalorieTrackingApp.DAL.Entities.Concrete;
using CalorieTrackingApp.DAL.Enums;
using CalorieTrackingApp.DAL.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieTrackingApp.DAL.Repositories.Concrete
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(DbContext dbContext) : base(dbContext)
        {

        }

        public ICollection<User> GetName(string name)
        {
            return _entities.Where(u => u.Name == name).ToList();
        }

        public ICollection<User> GetSurname(string surname)
        {
            return _entities.Where(u => u.Surname == surname).ToList();
        }

        public ICollection<User> GetEmail(string email)
        {
            return _entities.Where(u => u.Email == email).ToList();
        }

        public ICollection<User> GetUserName(string userName)
        {
            return _entities.Where(u => u.UserName == userName).ToList();
        }

        public ICollection<User> GetUserAgeGap(AgeGap ageGap)
        {
            return _entities.Where(u => u.UserAgeGap == ageGap).ToList();
        }

        public ICollection<User> GetUserGoal(Goal goal)
        {
            return _entities.Where(u => u.UserGoal == goal).ToList();
        }
    }
}
