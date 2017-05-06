using System.Collections.Generic;
using System.Linq;
using BLL.Entities;
using BLL.Interfaces;
using BLL.Mappers;
using DAL.Interfaces;
using DAL.Repositories;

namespace BLL.Services
{
    public class UserService 
        : IUserService
    {
        private readonly IUnitOfWork uow;
        private readonly IUserRepository userRepository;

        public UserService(IUnitOfWork uow, IUserRepository userRepository)
        {
            this.userRepository = userRepository;
            this.uow = uow;
        }

        public UserEntity GetUser(int id)
        {
            return userRepository.GetUser(id).ToBllUser();
        }

        public IEnumerable<UserEntity> GetAllUsers()
        {
            return userRepository.GetAllUsers().Select(user => user.ToBllUser());
        }

        public void CreateUser(UserEntity user)
        {
            userRepository.CreateUser(user.ToDalUser());
            uow.Commit();
        }

        public UserEntity GetUserByLogin(string login)
        {
            return userRepository.GetUserByLogin(login).ToBllUser();
        }
    }
}