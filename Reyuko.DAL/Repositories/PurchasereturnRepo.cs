using System.Collections.Generic;
using System.Linq;
using Reyuko.DAL.Domain;
using Reyuko.DAL.Interface;

namespace Reyuko.DAL.Repositories
{
    public class PurchasereturnRepo : Repository<Purchasereturn>, IPurchasereturnRepo
    {

        public PurchasereturnRepo(ReyukoContext context)
            : base(context)
        {

        }

       

        public IEnumerable<Purchasereturn> GetPaged(int pageIndex, int pageSize = 10)
        {
            return ReyukoContext.PurchaseReturns
                .OrderByDescending(m => m.IdReturPembelian)
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
