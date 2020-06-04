using System.Collections.Generic;
using System.Linq;
using Reyuko.DAL.Domain;
using Reyuko.DAL.Interface;

namespace Reyuko.DAL.Repositories
{
    public class OrderProdukBeliRepo : Repository<OrderProdukBeli>, IOrderProdukBeliRepo
    {

        public OrderProdukBeliRepo(ReyukoContext context)
            : base(context)
        {

        }

        public IEnumerable<OrderProdukBeli> GetPaged(int pageIndex, int pageSize = 10)
        {
            return ReyukoContext.OrderProdukBeli
                .OrderByDescending(m => m.IdOrderProdukBeli)
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
