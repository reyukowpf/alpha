using System.Collections.Generic;
using System.Linq;
using Reyuko.DAL.Domain;
using Reyuko.DAL.Interface;

namespace Reyuko.DAL.Repositories
{
    public class AlamatRepo : Repository<Alamat>, IAlamatRepo
    {

        public AlamatRepo(ReyukoContext context)
            : base(context)
        {

        }

        public IEnumerable<Alamat> GetPaged(int pageIndex, int pageSize = 10)
        {
            return ReyukoContext.Alamat
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
