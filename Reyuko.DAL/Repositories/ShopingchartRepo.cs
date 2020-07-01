using System.Collections.Generic;
using System.Linq;
using Reyuko.DAL.Domain;
using Reyuko.DAL.Interface;

namespace Reyuko.DAL.Repositories
{
    public class ShopingchartRepo : Repository<Shopingchart>, IShopingchartRepo
    {

        public ShopingchartRepo(ReyukoContext context)
            : base(context)
        {

        }

        public IEnumerable<Shopingchart> GetPaged(int pageIndex, int pageSize = 10)
        {
            return ReyukoContext.Shopingchart
                .OrderByDescending(m => m.IdPermintaanBarang)
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
