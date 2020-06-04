using System.Collections.Generic;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Interface
{
    public interface ITabelPenyusutanRepo : IRepository<TabelPenyusutan>
    {
        IEnumerable<TabelPenyusutan> GetPaged(int pageIndex, int pageSize);
    }
}
