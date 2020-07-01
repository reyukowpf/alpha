using System.Collections.Generic;
using System.Linq;
using Reyuko.DAL.Domain;
using Reyuko.DAL.Interface;

namespace Reyuko.DAL.Repositories
{
    public class OptionAnnualRepo : Repository<OptionAnnual>, IOptionAnnualRepo
    {

        public OptionAnnualRepo(ReyukoContext context)
            : base(context)
        {

        }

        public IEnumerable<OptionAnnual> GetPaged(int pageIndex, int pageSize = 10)
        {
            return ReyukoContext.OptionAnnual
                .OrderByDescending(m => m.IdOptionAnnual)
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
