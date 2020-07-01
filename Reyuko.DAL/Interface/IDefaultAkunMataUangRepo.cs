using System.Collections.Generic;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Interface
{
    public interface IDefaultAkunMataUangRepo : IRepository<DefaultAkunMataUang>
    {
        IEnumerable<DefaultAkunMataUang> GetPaged(int pageIndex, int pageSize);
    }
}
