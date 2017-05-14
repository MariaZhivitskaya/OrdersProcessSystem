using System.Collections.Generic;
using BLL.Entities;

namespace BLL.Interfaces
{
    public interface IRoleService
    {
        IEnumerable<RoleEntity> GetAllRoles();
        RoleEntity GetRole(int id);
    }
}