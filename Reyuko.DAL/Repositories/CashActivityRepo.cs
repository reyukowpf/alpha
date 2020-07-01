using System.Collections.Generic;
using System.Linq;
using Reyuko.DAL.Domain;
using Reyuko.DAL.Interface;

namespace Reyuko.DAL.Repositories
{
    public class CashActivityRepo : Repository<CashActivity>, ICashActivityRepo
    {

        public CashActivityRepo(ReyukoContext context)
            : base(context)
        {

        }

        public IEnumerable<CashActivity> GetPaged(int pageIndex, int pageSize = 10)
        {
            return ReyukoContext.CashActivitie
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
