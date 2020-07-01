using System.Collections.Generic;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Interface
{
    public interface IRecapRepo : IRepository<Recap>
    {
        IEnumerable<Recap> GetPaged(int pageIndex, int pageSize);
    }
}
