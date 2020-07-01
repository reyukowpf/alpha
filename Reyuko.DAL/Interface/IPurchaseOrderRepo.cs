using System.Collections.Generic;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Interface
{
    public interface IPurchaseOrderRepo : IRepository<PurchaseOrder>
    {
        IEnumerable<PurchaseOrder> GetPaged(int pageIndex, int pageSize);
    }
}
