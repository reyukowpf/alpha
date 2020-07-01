using System.Collections.Generic;
using System.Linq;
using Reyuko.DAL.Domain;
using Reyuko.DAL.Interface;

namespace Reyuko.DAL.Repositories
{
    public class OrderPembayaranGajiRepo : Repository<OrderPembayaranGaji>, IOrderPembayaranGajiRepo
    {

        public OrderPembayaranGajiRepo(ReyukoContext context)
            : base(context)
        {

        }

        public IEnumerable<OrderPembayaranGaji> GetPaged(int pageIndex, int pageSize = 10)
        {
            return ReyukoContext.OrderPembayaranGaji
                .OrderByDescending(m => m.Id)
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
