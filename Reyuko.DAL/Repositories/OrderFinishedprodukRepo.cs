using System.Collections.Generic;
using System.Linq;
using Reyuko.DAL.Domain;
using Reyuko.DAL.Interface;

namespace Reyuko.DAL.Repositories
{
    public class OrderFinishedprodukRepo : Repository<OrderFinishedproduk>, IOrderFinishedprodukRepo
    {

        public OrderFinishedprodukRepo(ReyukoContext context)
            : base(context)
        {

        }

        public IEnumerable<OrderFinishedproduk> GetPaged(int pageIndex, int pageSize = 10)
        {
            return ReyukoContext.OrderFinishedproduk
                .OrderByDescending(m => m.IdOrderFinishProduk)
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
