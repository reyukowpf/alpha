using System.Collections.Generic;
using System.Linq;
using Reyuko.DAL.Domain;
using Reyuko.DAL.Interface;

namespace Reyuko.DAL.Repositories
{
    public class SalesOrderRepo : Repository<SalesOrder>, ISalesOrderRepo
    {

        public SalesOrderRepo(ReyukoContext context)
            : base(context)
        {

        }

       

        public IEnumerable<SalesOrder> GetPaged(int pageIndex, int pageSize = 10)
        {
            return ReyukoContext.SalesOrders
                .OrderByDescending(m => m.IdOrderPenjualan)
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
