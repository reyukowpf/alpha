using System.Collections.Generic;
using System.Linq;
using Reyuko.DAL.Domain;
using Reyuko.DAL.Interface;

namespace Reyuko.DAL.Repositories
{
    public class OrderJurnalUmumRepo : Repository<OrderJurnalUmum>, IOrderJurnalUmumRepo
    {

        public OrderJurnalUmumRepo(ReyukoContext context)
            : base(context)
        {

        }

        public IEnumerable<OrderJurnalUmum> GetPaged(int pageIndex, int pageSize = 10)
        {
            return ReyukoContext.OrderJurnalUmum
                .OrderByDescending(m => m.IdOrderJurnalUmum)
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
