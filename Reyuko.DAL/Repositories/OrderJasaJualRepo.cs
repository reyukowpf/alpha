using System.Collections.Generic;
using System.Linq;
using Reyuko.DAL.Domain;
using Reyuko.DAL.Interface;

namespace Reyuko.DAL.Repositories
{
    public class OrderJasaJualRepo : Repository<OrderJasaJual>, IOrderJasaJualRepo
    {

        public OrderJasaJualRepo(ReyukoContext context)
            : base(context)
        {

        }

        public IEnumerable<OrderJasaJual> GetPaged(int pageIndex, int pageSize = 10)
        {
            return ReyukoContext.OrderJasaJual
                .OrderByDescending(m => m.IdOrderJasa)
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
