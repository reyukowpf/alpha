using System.Collections.Generic;
using System.Linq;
using Reyuko.DAL.Domain;
using Reyuko.DAL.Interface;

namespace Reyuko.DAL.Repositories
{
    public class produkRepo : Repository<produk>, IprodukRepo
    {

        public produkRepo(ReyukoContext context)
            : base(context)
        {

        }

       

        public IEnumerable<produk> GetPaged(int pageIndex, int pageSize = 10)
        {
            return ReyukoContext.produk
                .OrderByDescending(m => m.IdProduk)
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
