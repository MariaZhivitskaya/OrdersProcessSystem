using DAL.DTO;
using ORM;

namespace DAL.Mappers
{
    public static class Mappers
    {
        public static DalUser ToDalUser(this User user)
        {
            return new DalUser()
            {
                Login = user.Login,
                Password = user.Password,
                Surname = user.Surname,
                Name = user.Name,
                RoleId = user.RoleId
            };
        }
    }
}