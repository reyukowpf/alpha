using System.Collections.Generic;
using System.Linq;
using Reyuko.DAL.Domain;
using Reyuko.DAL.Interface;

namespace Reyuko.DAL.Repositories
{
    public class HargaPokokRepo : Repository<HargaPokok>, IHargaPokokRepo
    {

        public HargaPokokRepo(ReyukoContext context)
            : base(context)
        {

        }

        public IEnumerable<HargaPokok> GetPaged(int pageIndex, int pageSize = 10)
        {
            return ReyukoContext.HargaPokok
                .OrderByDescending(m => m.IdTipeHargaPokok)
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
