using System.Collections.Generic;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Interface
{
    public interface IOrderPembayaranGajiRepo : IRepository<OrderPembayaranGaji>
    {
        IEnumerable<OrderPembayaranGaji> GetPaged(int pageIndex, int pageSize);
    }
}
