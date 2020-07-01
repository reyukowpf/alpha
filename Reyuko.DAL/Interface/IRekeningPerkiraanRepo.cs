using System.Collections.Generic;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Interface
{
    public interface IRekeningPerkiraanRepo : IRepository<RekeningPerkiraan>
    {
        IEnumerable<RekeningPerkiraan> GetPaged(int pageIndex, int pageSize);
    }
}
