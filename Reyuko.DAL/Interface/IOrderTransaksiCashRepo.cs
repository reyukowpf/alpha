using System.Collections.Generic;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Interface
{
    public interface IOrderTransaksiCashRepo : IRepository<OrderTransaksiCash>
    {
        IEnumerable<OrderTransaksiCash> GetPaged(int pageIndex, int pageSize);
    }
}
