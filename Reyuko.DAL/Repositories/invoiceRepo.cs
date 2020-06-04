using System.Collections.Generic;
using System.Linq;
using Reyuko.DAL.Domain;
using Reyuko.DAL.Interface;

namespace Reyuko.DAL.Repositories
{
    public class invoiceRepo : Repository<invoice>, IinvoiceRepo
    {

        public invoiceRepo(ReyukoContext context)
            : base(context)
        {

        }

        public IEnumerable<invoice> GetPaged(int pageIndex, int pageSize = 10)
        {
            return ReyukoContext.Invoice
                .OrderByDescending(m => m.IdInvoice)
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
