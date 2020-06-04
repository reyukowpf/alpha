using System.Collections.Generic;
using System.Linq;
using Reyuko.DAL.Domain;
using Reyuko.DAL.Interface;

namespace Reyuko.DAL.Repositories
{
    public class RekeningAnggaranRepo : Repository<RekeningAnggaran>, IRekeningAnggaranRepo
    {

        public RekeningAnggaranRepo(ReyukoContext context)
            : base(context)
        {

        }

        public IEnumerable<RekeningAnggaran> GetPaged(int pageIndex, int pageSize = 10)
        {
            return ReyukoContext.RekeningAnggaran
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
