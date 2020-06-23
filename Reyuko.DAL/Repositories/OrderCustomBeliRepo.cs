using System.Collections.Generic;
using System.Linq;
using Reyuko.DAL.Domain;
using Reyuko.DAL.Interface;

namespace Reyuko.DAL.Repositories
{
    public class OrderCustomBeliRepo : Repository<OrderCustomBeli>, IOrderCustomBeliRepo
    {

        public OrderCustomBeliRepo(ReyukoContext context)
            : base(context)
        {

        }

        public IEnumerable<OrderCustomBeli> GetPaged(int pageIndex, int pageSize = 10)
        {
            return ReyukoContext.OrderCustomBeli
                .OrderByDescending(m => m.IdOrderCustom)
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
