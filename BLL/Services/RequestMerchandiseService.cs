using System.Collections.Generic;
using System.Linq;
using BLL.Entities;
using BLL.Interfaces;
using DAL.Interfaces;
using BLL.Mappers;

namespace BLL.Services
{
    public class RequestMerchandiseService
        : IRequestMerchandiseService
    {
        private readonly IUnitOfWork uow;
        private readonly IRequestMerchandiseRepository requestMerchandiseRepository;

        public RequestMerchandiseService(IUnitOfWork uow, IRequestMerchandiseRepository requestMerchandiseRepository)
        {
            this.requestMerchandiseRepository = requestMerchandiseRepository;
            this.uow = uow;
        }

        public IEnumerable<RequestMerchandiseEntity> GetAllRequestMerchandises(int requestId)
        {
            return requestMerchandiseRepository.GetAllRequestMerchandises(requestId)
                .Select(requestMerchandise => requestMerchandise.ToBllRequestMerchandise());
        }
    }
}