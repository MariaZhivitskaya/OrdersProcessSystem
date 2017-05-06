using System.Collections.Generic;
using DAL.DTO;

namespace DAL.Interfaces
{
    public interface IRoleRepository
    {
        IEnumerable<DalRole> GetAllRoles();
        DalRole GetById(int? roleId);
    }
}