using System.Collections.Generic;
using System.Linq;
using Reyuko.DAL.Domain;
using Reyuko.DAL.Interface;

namespace Reyuko.DAL.Repositories
{
    public class OrderInventoriRepo : Repository<OrderInventori>, IOrderInventoriRepo
    {

        public OrderInventoriRepo(ReyukoContext context)
            : base(context)
        {

        }

        public IEnumerable<OrderInventori> GetPaged(int pageIndex, int pageSize = 10)
        {
            return ReyukoContext.OrderInventori
                .OrderByDescending(m => m.IdOrderInventori)
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
