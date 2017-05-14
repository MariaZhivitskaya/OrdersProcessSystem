using System.Collections.Generic;
using System.Linq;
using DAL.DTO;
using DAL.Interfaces;
using ORM;

namespace DAL.Repositories
{
    public class RequestMerchndiseRepository
        : IRequestMerchandiseRepository
    {
        private readonly DbModel context;

        public RequestMerchndiseRepository(DbModel model)
        {
            this.context = model;
        }

        public IEnumerable<DalRequestMerchandise> GetAllRequestMerchandises(int requestId)
        {
            var collection = context.Set<RequestMerchandise>().Where(
                requestMerchandise => requestMerchandise.RequestId == requestId);

            return collection.Select(requestMerchandiseTransform => new DalRequestMerchandise()
            {
                Id = requestMerchandiseTransform.Id,
                MerchandiseId = requestMerchandiseTransform.MerchandiseId,
                Amount = requestMerchandiseTransform.Amount,
                UserId = requestMerchandiseTransform.UserId,
                RequestId = requestMerchandiseTransform.RequestId
            });
        }
    }
}