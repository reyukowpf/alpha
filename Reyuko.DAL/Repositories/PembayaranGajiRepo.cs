using System.Collections.Generic;
using System.Linq;
using Reyuko.DAL.Domain;
using Reyuko.DAL.Interface;

namespace Reyuko.DAL.Repositories
{
    public class PembayaranGajiRepo : Repository<PembayaranGaji>, IPembayaranGajiRepo
    {

        public PembayaranGajiRepo(ReyukoContext context)
            : base(context)
        {

        }

        public IEnumerable<PembayaranGaji> GetPaged(int pageIndex, int pageSize = 10)
        {
            return ReyukoContext.PembayaranGaji
                .OrderByDescending(m => m.IdPembayaranGaji)
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
