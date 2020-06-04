using System.Collections.Generic;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Interface
{
    public interface IKursMataUangRepo : IRepository<KursMataUang>
    {
        IEnumerable<KursMataUang> GetPaged(int pageIndex, int pageSize);
    }
}
