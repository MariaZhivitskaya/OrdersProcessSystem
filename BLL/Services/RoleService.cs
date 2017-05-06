using System.Collections.Generic;
using System.Linq;
using BLL.Entities;
using BLL.Interfaces;
using BLL.Mappers;
using DAL.Interfaces;

namespace BLL.Services
{
    public class RoleService
        : IRoleService
    {
        private readonly IRoleRepository _roleRepository;

        public RoleService(IRoleRepository repository)
        {
            _roleRepository = repository;
        }

        public IEnumerable<RoleEntity> GetAllRoleEntities()
        {
            return _roleRepository.GetAllRoles().Select(role => role.ToBllRole());
        }
    }
}