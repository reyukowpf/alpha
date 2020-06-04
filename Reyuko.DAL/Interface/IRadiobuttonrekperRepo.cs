using System.Collections.Generic;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Interface
{
    public interface IRadiobuttonrekperRepo : IRepository<Radiobuttonrekper>
    {
        IEnumerable<Radiobuttonrekper> GetPaged(int pageIndex, int pageSize);

    }
}
