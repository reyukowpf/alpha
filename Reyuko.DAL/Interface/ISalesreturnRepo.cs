using System.Collections.Generic;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Interface
{
    public interface ISalesreturnRepo : IRepository<Salesreturn>
    {
        IEnumerable<Salesreturn> GetPaged(int pageIndex, int pageSize);
    }
}
