using System.Collections.Generic;
using System.Linq;
using Reyuko.DAL.Domain;
using Reyuko.DAL.Interface;

namespace Reyuko.DAL.Repositories
{
    public class OrderCustomJualRepo : Repository<OrderCustomJual>, IOrderCustomJualRepo
    {

        public OrderCustomJualRepo(ReyukoContext context)
            : base(context)
        {

        }
        public IEnumerable<OrderCustomJual> GetPaged(int pageIndex, int pageSize = 10)
        {
            return ReyukoContext.OrderCustomJual
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
