using System.Collections.Generic;
using System.Linq;
using Reyuko.DAL.Domain;
using Reyuko.DAL.Interface;

namespace Reyuko.DAL.Repositories
{
    public class ReceivedgoodRepo : Repository<Receivedgood>, IReceivedgoodRepo
    {

        public ReceivedgoodRepo(ReyukoContext context)
            : base(context)
        {

        }

       

        public IEnumerable<Receivedgood> GetPaged(int pageIndex, int pageSize = 10)
        {
            return ReyukoContext.Receivedgood
                .OrderByDescending(m => m.IdOrder)
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
