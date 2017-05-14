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
                Id = user.Id,
                Login = user.Login,
                Password = user.Password,
                Surname = user.Surname,
                Name = user.Name,
                RoleId = user.RoleId
            };
        }

        public static DalRole ToDalRole(this Role role)
        {
            return new DalRole()
            {
                Id = role.Id,
                Description = role.Description
            };
        }

        public static DalMerchandise ToDalMerchandise(this Merchandise merchandise)
        {
            return new DalMerchandise()
            {
                Id = merchandise.Id,
                Amount = merchandise.Amount,
                Name = merchandise.Name,
                Price = merchandise.Price
            };
        }

        public static DalRequestMerchandise ToDalRequestMerchandise(this RequestMerchandise requestMerchandise)
        {
            return new DalRequestMerchandise()
            {
                Id = requestMerchandise.Id,
                MerchandiseId = requestMerchandise.MerchandiseId,
                Amount = requestMerchandise.Amount,
                UserId = requestMerchandise.UserId,
                RequestId = requestMerchandise.RequestId
            };
        }

        public static DalRequest ToDalRequest(this Request request)
        {
            return new DalRequest()
            {
                Id = request.Id,
                AdditionalInfo = request.AdditionalInfo
            };
        }
    }
}