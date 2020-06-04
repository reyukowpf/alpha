using System.Collections.Generic;
using System.Linq;
using Reyuko.DAL.Domain;
using Reyuko.DAL.Interface;

namespace Reyuko.DAL.Repositories
{
    public class QuotationrequestRepo : Repository<Quotationrequest>, IQuotationrequestRepo
    {

        public QuotationrequestRepo(ReyukoContext context)
            : base(context)
        {

        }

        public IEnumerable<Quotationrequest> GetPaged(int pageIndex, int pageSize = 10)
        {
            return ReyukoContext.Quotationrequests
                .OrderByDescending(m => m.IdPermintaanPenawaranHarga)
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
