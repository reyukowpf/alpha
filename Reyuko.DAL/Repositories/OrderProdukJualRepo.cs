using System.Collections.Generic;
using System.Linq;
using Reyuko.DAL.Domain;
using Reyuko.DAL.Interface;

namespace Reyuko.DAL.Repositories
{
    public class OrderProdukJualRepo : Repository<OrderProdukJual>, IOrderProdukJualRepo
    {

        public OrderProdukJualRepo(ReyukoContext context)
            : base(context)
        {

        }

        public IEnumerable<OrderProdukJual> GetPaged(int pageIndex, int pageSize = 10)
        {
            return ReyukoContext.OrderProdukJual
                .OrderByDescending(m => m.IdOrderProdukJual)
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
