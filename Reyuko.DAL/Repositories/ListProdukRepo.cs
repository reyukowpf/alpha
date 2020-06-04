using System.Collections.Generic;
using System.Linq;
using Reyuko.DAL.Domain;
using Reyuko.DAL.Interface;

namespace Reyuko.DAL.Repositories
{
    public class ListProdukRepo : Repository<ListProduk>, IListProdukRepo
    {

        public ListProdukRepo(ReyukoContext context)
            : base(context)
        {

        }

        public IEnumerable<ListProduk> GetPaged(int pageIndex, int pageSize = 10)
        {
            return ReyukoContext.ListProduk
                .OrderByDescending(m => m.IdListProduk)
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
