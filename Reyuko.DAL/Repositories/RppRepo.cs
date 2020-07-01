using System.Collections.Generic;
using System.Linq;
using Reyuko.DAL.Domain;
using Reyuko.DAL.Interface;

namespace Reyuko.DAL.Repositories
{
    public class RppRepo : Repository<Rpp>, IRppRepo
    {

        public RppRepo(ReyukoContext context)
            : base(context)
        {

        }

        public IEnumerable<Rpp> GetPaged(int pageIndex, int pageSize = 10)
        {
            return ReyukoContext.Rpp
                .OrderByDescending(m => m.IdRpp)
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
