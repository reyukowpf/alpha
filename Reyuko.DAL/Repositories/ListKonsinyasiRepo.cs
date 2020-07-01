using System.Collections.Generic;
using System.Linq;
using Reyuko.DAL.Domain;
using Reyuko.DAL.Interface;

namespace Reyuko.DAL.Repositories
{
    public class ListKonsinyasiRepo : Repository<ListKonsinyasi>, IListKonsinyasiRepo
    {

        public ListKonsinyasiRepo(ReyukoContext context)
            : base(context)
        {

        }

        public IEnumerable<ListKonsinyasi> GetPaged(int pageIndex, int pageSize = 10)
        {
            return ReyukoContext.ListKonsinyasi
                .OrderByDescending(m => m.IdListKonsinyasi)
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
