using System.Collections.Generic;
using DAL.DTO;

namespace DAL.Interfaces
{
    public interface IRequestMerchandiseRepository
    {
        IEnumerable<DalRequestMerchandise> GetAllRequestMerchandises(int requestId);
    }
}