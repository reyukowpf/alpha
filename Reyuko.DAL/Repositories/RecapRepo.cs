using System.Collections.Generic;
using System.Linq;
using Reyuko.DAL.Domain;
using Reyuko.DAL.Interface;

namespace Reyuko.DAL.Repositories
{
    public class RecapRepo : Repository<Recap>, IRecapRepo
    {

        public RecapRepo(ReyukoContext context)
            : base(context)
        {

        }

        public IEnumerable<Recap> GetPaged(int pageIndex, int pageSize = 10)
        {
            return ReyukoContext.Recap
                .OrderByDescending(m => m.IdRecap)
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
