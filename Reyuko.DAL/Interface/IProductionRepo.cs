using System.Collections.Generic;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Interface
{
    public interface IproductionRepo : IRepository<production>
    {
        IEnumerable<production> GetPaged(int pageIndex, int pageSize);
    }
}
