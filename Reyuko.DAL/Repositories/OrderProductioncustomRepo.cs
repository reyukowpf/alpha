using System.Collections.Generic;
using System.Linq;
using Reyuko.DAL.Domain;
using Reyuko.DAL.Interface;

namespace Reyuko.DAL.Repositories
{
    public class OrderProductioncustomRepo : Repository<OrderProductioncustom>, IOrderProductioncustomRepo
    {

        public OrderProductioncustomRepo(ReyukoContext context)
            : base(context)
        {

        }

        public IEnumerable<OrderProductioncustom> GetPaged(int pageIndex, int pageSize = 10)
        {
            return ReyukoContext.OrderProductioncustom
                .OrderByDescending(m => m.IdOrderProductionCustom)
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
