using System.Collections.Generic;
using DAL.DTO;

namespace DAL.Interfaces
{
    public interface IMerchandiseRepository
    {
        DalMerchandise GetMerchandise(int id);
        IEnumerable<DalMerchandise> GetAllMerchandises();
    }
}