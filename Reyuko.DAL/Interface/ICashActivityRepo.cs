using System.Collections.Generic;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Interface
{
    public interface ICashActivityRepo : IRepository<CashActivity>
    {
        IEnumerable<CashActivity> GetPaged(int pageIndex, int pageSize);
    }
}
