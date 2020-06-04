using System.Collections.Generic;
using System.Linq;
using Reyuko.DAL.Domain;
using Reyuko.DAL.Interface;

namespace Reyuko.DAL.Repositories
{
    public class TypelistRepo : Repository<Typelist>, ITypelistRepo
    {

        public TypelistRepo(ReyukoContext context)
            : base(context)
        {

        }

        public IEnumerable<Typelist> GetPaged(int pageIndex, int pageSize = 10)
        {
            return ReyukoContext.Typelist
                .OrderByDescending(m => m.IdTypeList)
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
