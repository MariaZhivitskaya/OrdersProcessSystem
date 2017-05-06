using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using DAL.DTO;
using DAL.Interfaces;
using ORM;

namespace DAL.Repositories
{
    public class RoleRepository
        : IRoleRepository
    {
        private readonly DbContext _context;

        public RoleRepository(DbContext uow)
        {
            _context = uow;
        }

        public IEnumerable<DalRole> GetAllRoles()
        {
            return _context.Set<Role>().Select(role => new DalRole()
            {
                Id = role.Id,
                Description = role.Description
            });
        }

        public DalRole GetById(int? roleId)
        {
            var getRole = _context.Set<Role>().FirstOrDefault(role => role.Id == roleId);
            return new DalRole()
            {
                Id = getRole.Id,
                Description = getRole.Description
            };
        }
    }
}