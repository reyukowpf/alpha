using System.Collections.Generic;
using System.Linq;
using Reyuko.DAL.Domain;
using Reyuko.DAL.Interface;

namespace Reyuko.DAL.Repositories
{
    public class PurchasedeliveryRepo : Repository<Purchasedelivery>, IPurchasedeliveryRepo
    {

        public PurchasedeliveryRepo(ReyukoContext context)
            : base(context)
        {

        }

       

        public IEnumerable<Purchasedelivery> GetPaged(int pageIndex, int pageSize = 10)
        {
            return ReyukoContext.PurchaseDeliverys
                .OrderByDescending(m => m.IdPengirimanBarangPembelian)
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
