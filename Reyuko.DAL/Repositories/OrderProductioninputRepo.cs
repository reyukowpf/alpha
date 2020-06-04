using System.Collections.Generic;
using System.Linq;
using Reyuko.DAL.Domain;
using Reyuko.DAL.Interface;

namespace Reyuko.DAL.Repositories
{
    public class OrderProductioninputRepo : Repository<OrderProductioninput>, IOrderProductioninputRepo
    {

        public OrderProductioninputRepo(ReyukoContext context)
            : base(context)
        {

        }

        public IEnumerable<OrderProductioninput> GetPaged(int pageIndex, int pageSize = 10)
        {
            return ReyukoContext.OrderProductioninput
                .OrderByDescending(m => m.IdOrderProduction)
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
