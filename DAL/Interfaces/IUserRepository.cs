using System.Collections.Generic;
using DAL.DTO;

namespace DAL.Interfaces
{
    public interface IUserRepository
    {
        DalUser GetUser(int id);
        IEnumerable<DalUser> GetAllUsers();
        void CreateUser(DalUser user);
        DalUser GetUserByLogin(string login);
    }
}