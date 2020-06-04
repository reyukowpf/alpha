using System.Collections.Generic;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Interface
{
    public interface IDropdownPaymentCashActivityRepo : IRepository<DropdownPaymentCashActivity>
    {
        IEnumerable<DropdownPaymentCashActivity> GetPaged(int pageIndex, int pageSize);
    }
}
