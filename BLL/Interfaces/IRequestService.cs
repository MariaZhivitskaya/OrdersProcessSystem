using System.Collections.Generic;
using BLL.Entities;

namespace BLL.Interfaces
{
    public interface IRequestService
    {
        RequestEntity GetRequest(int id);
        IEnumerable<RequestEntity> GetAllRequests();
    }
}