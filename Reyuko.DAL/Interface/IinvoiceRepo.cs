using System.Collections.Generic;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Interface
{
    public interface IinvoiceRepo : IRepository<invoice>
    {
        IEnumerable<invoice> GetPaged(int pageIndex, int pageSize);
    }
}
