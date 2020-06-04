using System.Collections.Generic;
using System.Linq;
using Reyuko.DAL.Domain;
using Reyuko.DAL.Interface;

namespace Reyuko.DAL.Repositories
{
    public class DataDepartemenRepo : Repository<DataDepartemen>, IDataDepartemenRepo
    {

        public DataDepartemenRepo(ReyukoContext context)
            : base(context)
        {

        }

        public IEnumerable<DataDepartemen> GetPaged(int pageIndex, int pageSize = 10)
        {
            return ReyukoContext.DataDepartemen
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
