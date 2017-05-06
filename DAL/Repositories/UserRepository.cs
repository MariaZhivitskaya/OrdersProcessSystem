using System.Collections.Generic;
using System.Linq;
using DAL.DTO;
using DAL.Interfaces;
using DAL.Mappers;
using ORM;

namespace DAL.Repositories
{
    public class UserRepository
        : IUserRepository
    {
        private readonly DbModel context;

        public UserRepository(DbModel model)
        {
            this.context = model;
        }

        public DalUser GetUser(int id)
        {
            return context.Set<User>().FirstOrDefault(user => user.Id == id).ToDalUser();
        }

        public IEnumerable<DalUser> GetAllUsers()
        {
            return context.Set<User>().Select(user => new DalUser()
            {
                Id = user.Id,
                Login = user.Login,
                Password = user.Password,
                Surname = user.Surname,
                Name = user.Name,
                RoleId = user.RoleId
            });
        }

        public void CreateUser(DalUser user)
        {
            var newUser = new User()
            {
                Login = user.Login,
                Password = user.Password,
                Surname = user.Surname,
                Name = user.Name,
                RoleId = user.RoleId
            };

            var dalUser = context.Set<User>().Add(newUser);
            context.SaveChanges();
        }

        public DalUser GetUserByLogin(string login)
        {
            var ormuser = context.Set<User>().FirstOrDefault(user => user.Login == login);
            if (ormuser == null)
                return null;

            return new DalUser()
            {
                Id = ormuser.Id,
                Login = ormuser.Login,
                Password = ormuser.Password,
                Surname = ormuser.Surname,
                Name = ormuser.Name,
                RoleId = ormuser.RoleId
            };
        }
    }
}