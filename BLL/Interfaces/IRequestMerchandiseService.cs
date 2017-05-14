using System.Collections.Generic;
using BLL.Entities;

namespace BLL.Interfaces
{
    public interface IRequestMerchandiseService
    {
        IEnumerable<RequestMerchandiseEntity> GetAllRequestMerchandises(int requestId);
    }
}