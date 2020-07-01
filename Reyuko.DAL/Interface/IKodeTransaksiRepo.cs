using System.Collections.Generic;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Interface
{
    public interface IKodeTransaksiRepo : IRepository<KodeTransaksi>
    {
        IEnumerable<KodeTransaksi> GetPaged(int pageIndex, int pageSize);
    }
}
