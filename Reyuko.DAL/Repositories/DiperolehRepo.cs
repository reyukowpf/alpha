using System.Collections.Generic;
using System.Linq;
using Reyuko.DAL.Domain;
using Reyuko.DAL.Interface;

namespace Reyuko.DAL.Repositories
{
    public class DiperolehRepo : Repository<Diperoleh>, IDiperolehRepo
    {

        public DiperolehRepo(ReyukoContext context)
            : base(context)
        {

        }

        public IEnumerable<Diperoleh> GetPaged(int pageIndex, int pageSize = 10)
        {
            return ReyukoContext.Diperoleh
                .OrderByDescending(m => m.IdDiperoleh)
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
