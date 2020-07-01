using System.Collections.Generic;
using System.Linq;
using Reyuko.DAL.Domain;
using Reyuko.DAL.Interface;

namespace Reyuko.DAL.Repositories
{
    public class TermspembayaranRepo : Repository<Termspembayaran>, ITermspembayaranRepo
    {

        public TermspembayaranRepo(ReyukoContext context)
            : base(context)
        {

        }

       

        public IEnumerable<Termspembayaran> GetPaged(int pageIndex, int pageSize = 10)
        {
            return ReyukoContext.Termspembayaran
                .OrderByDescending(m => m.IdTermPembayaran)
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
