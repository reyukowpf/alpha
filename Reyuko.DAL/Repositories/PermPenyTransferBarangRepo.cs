using System.Collections.Generic;
using System.Linq;
using Reyuko.DAL.Domain;
using Reyuko.DAL.Interface;

namespace Reyuko.DAL.Repositories
{
    public class PermPenyTransferBarangRepo : Repository<PermPenyTransferBarang>, IPermPenyTransferBarangRepo
    {

        public PermPenyTransferBarangRepo(ReyukoContext context)
            : base(context)
        {

        }

        public IEnumerable<PermPenyTransferBarang> GetPaged(int pageIndex, int pageSize = 10)
        {
            return ReyukoContext.PermPenyTransferBarang
                .OrderByDescending(m => m.IdPemPenydanTransferBarang)
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
