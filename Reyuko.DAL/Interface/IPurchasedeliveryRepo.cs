using System.Collections.Generic;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Interface
{
    public interface IPurchasedeliveryRepo : IRepository<Purchasedelivery>
    {
        IEnumerable<Purchasedelivery> GetPaged(int pageIndex, int pageSize);
    }
}
