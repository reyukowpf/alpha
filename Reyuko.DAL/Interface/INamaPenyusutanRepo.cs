using System.Collections.Generic;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Interface
{
    public interface INamaPenyusutanRepo : IRepository<NamaPenyusutan>
    {
        IEnumerable<NamaPenyusutan> GetPaged(int pageIndex, int pageSize);

    }
}
