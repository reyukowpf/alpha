using System.Collections.Generic;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Interface
{
    public interface IDeliveryorderRepo : IRepository<Deliveryorders>
    {
        IEnumerable<Deliveryorders> GetPaged(int pageIndex, int pageSize);
    }
}
