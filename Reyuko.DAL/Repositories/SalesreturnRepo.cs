using System.Collections.Generic;
using System.Linq;
using Reyuko.DAL.Domain;
using Reyuko.DAL.Interface;

namespace Reyuko.DAL.Repositories
{
    public class SalesreturnRepo : Repository<Salesreturn>, ISalesreturnRepo
    {

        public SalesreturnRepo(ReyukoContext context)
            : base(context)
        {

        }

        public IEnumerable<Salesreturn> GetPaged(int pageIndex, int pageSize = 10)
        {
            return ReyukoContext.Salesreturns
                .OrderByDescending(m => m.IdReturPenjualan)
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
