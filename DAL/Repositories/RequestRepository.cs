using System.Collections.Generic;
using System.Linq;
using DAL.DTO;
using DAL.Interfaces;
using DAL.Mappers;
using ORM;

namespace DAL.Repositories
{
    public class RequestRepository
        : IRequestRepository
    {
        private readonly DbModel context;

        public RequestRepository(DbModel model)
        {
            this.context = model;
        }

        public DalRequest GetRequest(int id)
        {
            return context.Set<Request>().FirstOrDefault(request => request.Id == id).ToDalRequest();
        }

        public IEnumerable<DalRequest> GetAllRequests()
        {
            return context.Set<Request>().Select(request => new DalRequest()
            {
                Id = request.Id,
                AdditionalInfo = request.AdditionalInfo
            });
        }
    }
}