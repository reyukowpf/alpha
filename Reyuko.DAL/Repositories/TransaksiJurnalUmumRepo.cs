using System.Collections.Generic;
using System.Linq;
using Reyuko.DAL.Domain;
using Reyuko.DAL.Interface;

namespace Reyuko.DAL.Repositories
{
    public class TransaksiJurnalUmumRepo : Repository<TransaksiJurnalUmum>, ITransaksiJurnalUmumRepo
    {

        public TransaksiJurnalUmumRepo(ReyukoContext context)
            : base(context)
        {

        }

        public IEnumerable<TransaksiJurnalUmum> GetPaged(int pageIndex, int pageSize = 10)
        {
            return ReyukoContext.TransaksiJurnalUmum
                .OrderByDescending(m => m.IdTransaksiJurnalUmum)
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
