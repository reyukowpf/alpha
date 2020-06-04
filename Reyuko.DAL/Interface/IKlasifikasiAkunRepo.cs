using System.Collections.Generic;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Interface
{
    public interface IKlasifikasiAkunRepo : IRepository<KlasifikasiAkun>
    {
        IEnumerable<KlasifikasiAkun> GetPaged(int pageIndex, int pageSize);
    }
}
