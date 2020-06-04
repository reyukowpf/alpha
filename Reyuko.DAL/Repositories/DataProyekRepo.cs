using System.Collections.Generic;
using System.Linq;
using Reyuko.DAL.Domain;
using Reyuko.DAL.Interface;

namespace Reyuko.DAL.Repositories
{
    public class DataProyekRepo : Repository<DataProyek>, IDataProyekRepo
    {

        public DataProyekRepo(ReyukoContext context)
            : base(context)
        {

        }

        public IEnumerable<DataProyek> GetPaged(int pageIndex, int pageSize = 10)
        {
            return ReyukoContext.DataProyek
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
