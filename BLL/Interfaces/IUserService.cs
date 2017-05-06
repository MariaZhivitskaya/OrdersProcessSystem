using System.Collections.Generic;
using BLL.Entities;

namespace BLL.Interfaces
{
    public interface IUserService
    {
        UserEntity GetUser(int id);
        IEnumerable<UserEntity> GetAllUsers();
        void CreateUser(UserEntity user);
        UserEntity GetUserByLogin(string login);
    }
}