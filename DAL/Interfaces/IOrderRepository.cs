using DAL.DTO;

namespace DAL.Interfaces
{
    public interface IOrderRepository
    {
        DalOrder GetOrder(int id);
    }
}