using System.Collections.Generic;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Interface
{
    public interface IGolonganKontakRepo : IRepository<GolonganKontak>
    {
        IEnumerable<GolonganKontak> GetPaged(int pageIndex, int pageSize);
    }
}
