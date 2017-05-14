using BLL.Entities;

namespace BLL.Interfaces
{
    public interface IMerchandiseService
    {
        MerchandiseEntity GetMerchandise(int id);
    }
}