using System.Collections.Generic;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Interface
{
    public interface ISatuanDasarRepo : IRepository<SatuanDasar>
    {
        IEnumerable<SatuanDasar> GetPaged(int pageIndex, int pageSize);
    }
}
