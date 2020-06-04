using System.Collections.Generic;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Interface
{
    public interface IKlasifikasiKontakRepo : IRepository<KlasifikasiKontak>
    {
        IEnumerable<KlasifikasiKontak> GetPaged(int pageIndex, int pageSize);
    }
}
