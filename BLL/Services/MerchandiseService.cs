using BLL.Entities;
using BLL.Interfaces;
using BLL.Mappers;
using DAL.Interfaces;

namespace BLL.Services
{
    public class MerchandiseService
        : IMerchandiseService
    {
        private readonly IMerchandiseRepository _merchandiseRepository;

        public MerchandiseService(IMerchandiseRepository merchandise)
        {
            _merchandiseRepository = merchandise;
        }

        public MerchandiseEntity GetMerchandise(int id)
        {
            return _merchandiseRepository.GetMerchandise(id).ToBllMerchandise();
        }
    }
}