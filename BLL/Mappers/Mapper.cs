using BLL.Entities;
using DAL.DTO;

namespace BLL.Mappers
{
    public static class Mapper
    {
        public static DalUser ToDalUser(this UserEntity userEntity)
        {
            return new DalUser()
            {
                Id = userEntity.Id,
                Login = userEntity.Login,
                Password = userEntity.Password,
                Surname = userEntity.Surname,
                Name = userEntity.Name,
                RoleId = userEntity.RoleId
            };
        }

        public static UserEntity ToBllUser(this DalUser dalUser)
        {
            if (dalUser == null)
                return null;

            return new UserEntity()
            {
                Id = dalUser.Id,
                Login = dalUser.Login,
                Password = dalUser.Password,
                Surname = dalUser.Surname,
                Name = dalUser.Name,
                RoleId = dalUser.RoleId
            };
        }

        public static RoleEntity ToBllRole(this DalRole dalRole)
        {
            return new RoleEntity()
            {
                Id = dalRole.Id,
                Description = dalRole.Description
            };
        }
    }
}