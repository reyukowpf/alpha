using System.Collections.Generic;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Interface
{
    public interface IKelompokHartaTetapRepo : IRepository<KelompokHartaTetap>
    {
        IEnumerable<KelompokHartaTetap> GetPaged(int pageIndex, int pageSize);
    }
}
