using System.Collections.Generic;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Interface
{
    public interface IPembayaranGajiRepo : IRepository<PembayaranGaji>
    {
        IEnumerable<PembayaranGaji> GetPaged(int pageIndex, int pageSize);
    }
}
