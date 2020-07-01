using System.Collections.Generic;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Interface
{
    public interface IPeriodeAkuntansiRepo : IRepository<PeriodeAkuntansi>
    {
        IEnumerable<PeriodeAkuntansi> GetPaged(int pageIndex, int pageSize);
    }
}
