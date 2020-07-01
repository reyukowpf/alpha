using System.Collections.Generic;
using System.Linq;
using Reyuko.DAL.Domain;
using Reyuko.DAL.Interface;

namespace Reyuko.DAL.Repositories
{
    public class PenerimaanBarangRepo : Repository<PenerimaanBarang>, IPenerimaanBarangRepo
    {

        public PenerimaanBarangRepo(ReyukoContext context)
            : base(context)
        {

        }

        public IEnumerable<PenerimaanBarang> GetPaged(int pageIndex, int pageSize = 10)
        {
            return ReyukoContext.PenerimaanBarang
                .OrderByDescending(m => m.IdPenerimaanBarangKonsinyasi)
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
