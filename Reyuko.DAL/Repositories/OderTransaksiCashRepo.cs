using System.Collections.Generic;
using System.Linq;
using Reyuko.DAL.Domain;
using Reyuko.DAL.Interface;

namespace Reyuko.DAL.Repositories
{
    public class OrderTransaksiCashRepo : Repository<OrderTransaksiCash>, IOrderTransaksiCashRepo
    {

        public OrderTransaksiCashRepo(ReyukoContext context)
            : base(context)
        {

        }

        public IEnumerable<OrderTransaksiCash> GetPaged(int pageIndex, int pageSize = 10)
        {
            return ReyukoContext.OrderTransaksiCash
                .OrderByDescending(m => m.IdOrderTransaksiCash)
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
