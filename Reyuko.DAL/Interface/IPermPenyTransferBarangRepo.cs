using System.Collections.Generic;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Interface
{
    public interface IPermPenyTransferBarangRepo : IRepository<PermPenyTransferBarang>
    {
        IEnumerable<PermPenyTransferBarang> GetPaged(int pageIndex, int pageSize);
    }
}
