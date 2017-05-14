using System.Collections.Generic;
using DAL.DTO;

namespace DAL.Interfaces
{
    public interface IRequestRepository
    {
        DalRequest GetRequest(int id);
        IEnumerable<DalRequest> GetAllRequests();
    }
}