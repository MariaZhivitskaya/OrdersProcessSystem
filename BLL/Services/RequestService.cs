using System.Collections.Generic;
using System.Linq;
using BLL.Entities;
using BLL.Interfaces;
using BLL.Mappers;
using DAL.Interfaces;

namespace BLL.Services
{
    public class RequestService
        : IRequestService
    {
        private readonly IUnitOfWork uow;
        private readonly IRequestRepository requestRepository;

        public RequestService(IUnitOfWork uow, IRequestRepository requestRepository)
        {
            this.requestRepository = requestRepository;
            this.uow = uow;
        }

        public RequestEntity GetRequest(int id)
        {
            return requestRepository.GetRequest(id).ToBllRequest();
        }

        public IEnumerable<RequestEntity> GetAllRequests()
        {
            return requestRepository.GetAllRequests().Select(request => request.ToBllRequest());
        }
    }
}