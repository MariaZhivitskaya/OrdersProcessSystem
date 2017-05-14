using BLL.Entities;
using OrderProcessWeb.ViewModels;

namespace OrderProcessWeb.Infrastructure.Mappers
{
    public static class WebApplicationMapper
    {
        public static UserEntity ToBllUser(this UserViewModel userViewModel) =>
          new UserEntity()
          {
              Id = userViewModel.Id,
              Login = userViewModel.Login,
              Password = userViewModel.Password,
              Surname = userViewModel.Surname,
              Name = userViewModel.Name,
              RoleId = userViewModel.RoleId
          };

        public static MerchandiseViewModel ToMerchandiseViewModel(this MerchandiseEntity merchandiseEntity) =>
         new MerchandiseViewModel()
         {
             Id = merchandiseEntity.Id,
             Amount = merchandiseEntity.Amount,
             Name = merchandiseEntity.Name,
             Price = merchandiseEntity.Price
         };
    }
}