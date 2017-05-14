using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using DAL.DTO;
using DAL.Interfaces;
using DAL.Mappers;
using ORM;

namespace DAL.Repositories
{
    public class MerchandiseRepository
        : IMerchandiseRepository
    {
        private readonly DbContext _context;

        public MerchandiseRepository(DbContext uow)
        {
            _context = uow;
        }

        public DalMerchandise GetMerchandise(int id)
        {
            return _context.Set<Merchandise>().FirstOrDefault(m => m.Id == id).ToDalMerchandise();
        }

        public IEnumerable<DalMerchandise> GetAllMerchandises()
        {
            throw new System.NotImplementedException();
        }
    }
}