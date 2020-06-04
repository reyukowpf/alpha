using System.Collections.Generic;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Interface
{
    public interface IPurchasereturnRepo : IRepository<Purchasereturn>
    {
        IEnumerable<Purchasereturn> GetPaged(int pageIndex, int pageSize);
    }
}
