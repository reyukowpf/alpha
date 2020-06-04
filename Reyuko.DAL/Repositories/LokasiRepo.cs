using System.Collections.Generic;
using System.Linq;
using Reyuko.DAL.Domain;
using Reyuko.DAL.Interface;

namespace Reyuko.DAL.Repositories
{
    public class LokasiRepo : Repository<Lokasi>, ILokasiRepo
    {

        public LokasiRepo(ReyukoContext context)
            : base(context)
        {

        }

        public IEnumerable<Lokasi> GetPaged(int pageIndex, int pageSize = 10)
        {
            return ReyukoContext.Lokasi
                .OrderByDescending(m => m.Id)
                .Skip((pageIndex - 1) * pageSize)
                .Take(pageSize)
                .ToList();
        }

        public ReyukoContext ReyukoContext
        {
            get { return _context as ReyukoContext; }
        }


    }
}
