using System.Collections.Generic;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Interface
{
    public interface IKontakRepo : IRepository<Kontak>
    {
        IEnumerable<Kontak> GetPaged(int pageIndex, int pageSize);
    }
}
